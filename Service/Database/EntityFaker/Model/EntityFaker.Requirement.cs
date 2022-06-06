using Microsoft.EntityFrameworkCore;
using Model;
using Service.Database.EntityFaker.Args;

namespace Service.Database.EntityFaker
{
    public static partial class EntityFaker
    {
        public static Requirement CreateRequirement(RequirementArgs? fakerArgs = null)
        {
            fakerArgs ??= new RequirementArgs();
            var requirement = _requirementFaker.Generate();
            requirement.Criterion = fakerArgs.Criterion;
            requirement.Indicator = fakerArgs.Indicator;

            if (fakerArgs.Save)
                Save(requirement);

            return requirement;
        }

        public static void Save(Requirement requirement)
        {
            using var context = GetContext();
            if (requirement.Criterion.CriterionId != 0)
                context.Entry(requirement.Criterion).State = EntityState.Unchanged;
            if (requirement.Indicator.IndicatorId != 0)
                context.Entry(requirement.Indicator).State = EntityState.Unchanged;
            context.Requirements.Add(requirement);
            context.SaveChanges();
        }

        public static void Update(Requirement requirement)
        {
            using var context = GetContext();
            context.Requirements.Add(requirement);
            context.SaveChanges();
        }

        public static void Remove(Requirement requirement, bool removeRelated = false)
        {
            using var context = GetContext();
            if (context.Requirements.Any(r => r == requirement))
            {
                context.Requirements.Remove(requirement);
                context.SaveChanges();
            }

            if (removeRelated)
            {
                if (requirement.Criterion is not null)
                {
                    Remove(requirement.Criterion);

                    if (context.Competences.Any(c => c == requirement.Criterion.Competence))
                        Remove(requirement.Criterion.Competence, true);
                }
                else
                {
                    var criterion = context.Criteria.Where(c => c.CriterionId == requirement.CriterionId).FirstOrDefault();

                    if (criterion is not null)
                    {
                        Remove(criterion);

                        if (context.Competences.Any(c => c == criterion.Competence))
                            Remove(criterion.Competence, true);
                    }
                }

                if (requirement.Indicator is not null)
                    Remove(requirement.Indicator);
                else
                {
                    var indicator = context.Indicators.Where(i => i.IndicatorId == requirement.IndicatorId).FirstOrDefault();

                    if (indicator is not null)
                        Remove(indicator);
                }
            }
        }

        public static IEnumerable<Requirement> CreateRequirements(RequirementsArgs? fakerArgs = null)
        {
            fakerArgs ??= new RequirementsArgs();
            using var context = new AssessmentContext();

            var requirements = new List<Requirement>(fakerArgs.Count);

            int id = fakerArgs.StartId;
            int count = fakerArgs.Count;
            while (count > 0)
            {
                requirements.Add(CreateRequirement(new RequirementArgs
                {
                    id = id,
                    Save = false,
                    Criterion = fakerArgs.Criterion,
                    Indicator = fakerArgs.Indicator,
                }));

                id = requirements.Last().RequirementId + 1;
                count--;
            }

            if (fakerArgs.Save)
                SaveRange(requirements);

            return requirements;
        }

        public static void SaveRange(IEnumerable<Requirement> requirements)
        {
            using var context = GetContext();
            context.Requirements.AddRange(requirements);
            context.SaveChanges();
        }

        public static void UpdateRange(IEnumerable<Requirement> requirements)
        {
            using var context = GetContext();
            context.Requirements.AddRange(requirements);
            context.SaveChanges();
        }

        public static void RemoveRange(IEnumerable<Requirement> requirements, bool removeRelated = false)
        {
            using var context = GetContext();
            context.RemoveRange(requirements);
            context.SaveChanges();
            context.Dispose();

            if (removeRelated)
            {
                requirements
                    .GroupBy(r => r.Criterion)
                    .Select(r => r.FirstOrDefault())
                    .ToList()
                    .ForEach(r =>
                    {
                        if (r is not null)
                            Remove(r.Criterion, true);
                    });

                requirements
                    .GroupBy(r => r.Indicator)
                    .Select(r => r.FirstOrDefault())
                    .ToList()
                    .ForEach(r =>
                    {
                        if (r is not null)
                            Remove(r.Indicator);
                    });
            }
        }
    }

    public partial class EntityFakerContained
    {
        public Container<Requirement> CreateRequirement(RequirementArgs? fakerArgs = null)
        {
            fakerArgs ??= new RequirementArgs();
            fakerArgs.Save = false;

            var requirement = EntityFaker.CreateRequirement(fakerArgs);
            return new Container<Requirement>(requirement,
                () => EntityFaker.Save(requirement),
                () => EntityFaker.Update(requirement),
                () => EntityFaker.Remove(requirement, fakerArgs.RemoveRelated)
            );
        }

        public Container<IEnumerable<Requirement>> CreateRequirements(RequirementsArgs? fakerArgs = null)
        {
            fakerArgs ??= new RequirementsArgs();
            fakerArgs.Save = false;

            var requirements = EntityFaker.CreateRequirements(fakerArgs);
            return new Container<IEnumerable<Requirement>>(requirements,
                () => EntityFaker.SaveRange(requirements),
                () => EntityFaker.UpdateRange(requirements),
                () => EntityFaker.RemoveRange(requirements, fakerArgs.RemoveRelated)
            );
        }
    }
}

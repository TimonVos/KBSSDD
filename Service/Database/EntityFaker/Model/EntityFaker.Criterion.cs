using Microsoft.EntityFrameworkCore;
using Model;
using Service.Database.EntityFaker.Args;

namespace Service.Database.EntityFaker
{
    public static partial class EntityFaker
    {
        public static Criterion CreateCriterion(CriterionArgs? fakerArgs = null)
        {
            fakerArgs ??= new CriterionArgs();
            var criterion = _criterionFaker.Generate();
            criterion.Competence = fakerArgs.Competence;

            if (fakerArgs.Save)
                Save(criterion);

            return criterion;
        }

        public static void Save(Criterion criterion)
        {
            using var context = GetContext();
            if (criterion.Competence.CompetenceId != 0)
                context.Entry(criterion.Competence).State = EntityState.Unchanged;
            context.Criteria.Add(criterion);
            context.SaveChanges();
        }

        public static void Update(Criterion criterion)
        {
            using var context = GetContext();
            context.Criteria.Add(criterion);
            context.SaveChanges();
        }

        public static void Remove(Criterion criterion, bool removeRelated = false)
        {
            using var context = GetContext();
            if (context.Criteria.Any(c => c == criterion))
            {
                context.Criteria.Remove(criterion);
                context.SaveChanges();
            }

            if (removeRelated)
            {
                if (criterion.Competence is not null)
                    Remove(criterion.Competence, true);
                else
                {
                    var competence = context.Competences.Where(c => c.CompetenceId == criterion.CompetenceId).FirstOrDefault();

                    if (competence is not null)
                        Remove(competence, true);
                }
            }
        }

        public static IEnumerable<Criterion> CreateCriteria(CriteriaArgs? fakerArgs = null)
        {
            fakerArgs ??= new CriteriaArgs();
            using var context = new AssessmentContext();

            var criteria = new List<Criterion>(fakerArgs.Count);

            int id = fakerArgs.StartId;
            int count = fakerArgs.Count;
            while (count > 0)
            {
                criteria.Add(CreateCriterion(new CriterionArgs
                {
                    id = id,
                    Save = false,
                    Competence = fakerArgs.Competence,
                }));

                id = criteria.Last().CriterionId + 1;
                count--;
            }

            if (fakerArgs.Save)
                SaveRange(criteria);

            return criteria;
        }

        public static void SaveRange(IEnumerable<Criterion> criteria)
        {
            using var context = GetContext();
            context.Criteria.AddRange(criteria);
            context.SaveChanges();
        }

        public static void UpdateRange(IEnumerable<Criterion> criteria)
        {
            using var context = GetContext();
            context.Criteria.AddRange(criteria);
            context.SaveChanges();
        }

        public static void RemoveRange(IEnumerable<Criterion> criteria, bool removeRelated = false)
        {
            using var context = GetContext();
            context.RemoveRange(criteria);
            context.SaveChanges();
            context.Dispose();

            if (removeRelated)
                criteria
                    .GroupBy(c => c.Competence)
                    .Select(c => c.FirstOrDefault())
                    .ToList()
                    .ForEach(c =>
                    {
                        if (c is not null)
                            Remove(c.Competence);
                    });
        }
    }

    public partial class EntityFakerContained
    {
        public Container<Criterion> CreateCriterion(CriterionArgs? fakerArgs = null)
        {
            fakerArgs ??= new CriterionArgs();
            fakerArgs.Save = false;

            var criterion = EntityFaker.CreateCriterion(fakerArgs);
            return new Container<Criterion>(criterion,
                () => EntityFaker.Save(criterion),
                () => EntityFaker.Update(criterion),
                () => EntityFaker.Remove(criterion, fakerArgs.RemoveRelated)
            );
        }

        public Container<IEnumerable<Criterion>> CreateCriteria(CriteriaArgs? fakerArgs = null)
        {
            fakerArgs ??= new CriteriaArgs();
            fakerArgs.Save = false;

            var criteria = EntityFaker.CreateCriteria(fakerArgs);
            return new Container<IEnumerable<Criterion>>(criteria,
                () => EntityFaker.SaveRange(criteria),
                () => EntityFaker.UpdateRange(criteria),
                () => EntityFaker.RemoveRange(criteria, fakerArgs.RemoveRelated)
            );
        }
    }
}

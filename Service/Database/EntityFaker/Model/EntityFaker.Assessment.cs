using Microsoft.EntityFrameworkCore;
using Model;
using Service.Database.EntityFaker.Args;

namespace Service.Database.EntityFaker
{
    public static partial class EntityFaker
    {
        public static Assessment CreateAssessment(AssessmentArgs? fakerArgs = null)
        {
            fakerArgs ??= new AssessmentArgs();
            var assessment = new Assessment
            {
                Group = fakerArgs.Group,
                Project = fakerArgs.Project
            };


            if (fakerArgs.Save)
                Save(assessment);

            return assessment;
        }

        public static void Save(Assessment assessment)
        {
            using var context = GetContext();
            if (assessment.Group.GroupId != 0)
                context.Entry(assessment.Group).State = EntityState.Modified;
            if (assessment.Project.ProjectId != 0)
                context.Entry(assessment.Project).State = EntityState.Modified;
            context.Assessments.Add(assessment);
            context.SaveChanges();
        }

        public static void Update(Assessment assessment)
        {
            using var context = GetContext();
            context.Assessments.Add(assessment);
            context.SaveChanges();
        }

        public static void Remove(Assessment assessment, bool removeRelated = false)
        {
            using var context = GetContext();
            if (context.Assessments.Any(p => p == assessment))
            {
                context.Assessments.Remove(assessment);
                context.SaveChanges();
            }

            if (removeRelated)
            {
                if (assessment.Group is not null)
                    Remove(assessment.Group);
                else
                {
                    var group = context.Groups.Where(g => g.GroupId == assessment.GroupId).FirstOrDefault();

                    if (group is not null)
                        Remove(group);
                }

                if (assessment.Project is not null)
                    Remove(assessment.Project, true);
                else
                {
                    var project = context.Projects.Where(p => p.ProjectId == assessment.ProjectId).FirstOrDefault();

                    if (project is not null)
                    {
                        Remove(project, true);
                    }
                }
            }
        }

        public static IEnumerable<Assessment> CreateAssessments(AssessmentsArgs? fakerArgs = null)
        {
            fakerArgs ??= new AssessmentsArgs();
            using var context = new AssessmentContext();

            var assessments = new List<Assessment>(fakerArgs.Count);

            int id = fakerArgs.StartId;
            int count = fakerArgs.Count;
            while (count > 0)
            {
                assessments.Add(CreateAssessment(new AssessmentArgs
                {
                    id = id,
                    Save = false,
                    Group = fakerArgs.Group,
                    Project = fakerArgs.Project,
                }));

                id = assessments.Last().AssessmentId + 1;
                count--;
            }

            if (fakerArgs.Save)
                SaveRange(assessments);

            return assessments;
        }

        public static void SaveRange(IEnumerable<Assessment> assessments)
        {
            using var context = GetContext();
            context.Assessments.AddRange(assessments);
            context.SaveChanges();
        }

        public static void UpdateRange(IEnumerable<Assessment> assessments)
        {
            using var context = GetContext();
            context.Assessments.AddRange(assessments);
            context.SaveChanges();
        }

        public static void RemoveRange(IEnumerable<Assessment> assessments, bool removeRelated = false)
        {
            using var context = GetContext();
            context.RemoveRange(assessments);
            context.SaveChanges();
            context.Dispose();

            if (removeRelated)
            {
                assessments 
                    .GroupBy(a => a.Group)
                    .Select(a => a.FirstOrDefault())
                    .ToList()
                    .ForEach(a =>
                    {
                        if (a is not null)
                            Remove(a.Group);
                    });

                assessments
                    .GroupBy(a => a.Project)
                    .Select(a => a.FirstOrDefault())
                    .ToList()
                    .ForEach(a =>
                    {
                        if (a is not null)
                            Remove(a.Project);
                    });
            }
        }
    }

    public partial class EntityFakerContained
    {
        public Container<Assessment> CreateAssessment(AssessmentArgs? fakerArgs = null)
        {
            fakerArgs ??= new AssessmentArgs();
            fakerArgs.Save = false;

            var assessment = EntityFaker.CreateAssessment(fakerArgs);
            return new Container<Assessment>(assessment,
                () => EntityFaker.Save(assessment),
                () => EntityFaker.Update(assessment),
                () => EntityFaker.Remove(assessment, fakerArgs.RemoveRelated)
            );
        }

        public Container<IEnumerable<Assessment>> CreateAssessments(AssessmentsArgs? fakerArgs = null)
        {
            fakerArgs ??= new AssessmentsArgs();
            fakerArgs.Save = false;

            var assessments = EntityFaker.CreateAssessments(fakerArgs);
            return new Container<IEnumerable<Assessment>>(assessments,
                () => EntityFaker.SaveRange(assessments),
                () => EntityFaker.UpdateRange(assessments),
                () => EntityFaker.RemoveRange(assessments, fakerArgs.RemoveRelated)
            );
        }
    }
}

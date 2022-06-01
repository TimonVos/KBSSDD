using Microsoft.EntityFrameworkCore;
using Model;
using Service.Database.EntityFaker.Args;

namespace Service.Database.EntityFaker
{
    public static partial class EntityFaker
    {
        public static Competence CreateCompetence(CompetenceArgs? fakerArgs = null)
        {
            fakerArgs ??= new CompetenceArgs();
            var competence = _competenceFaker.Generate();

            using var context = GetContext();
            if (context.Forms.Any(f => f == fakerArgs.Form))
                competence.FormId = fakerArgs.Form.FormId;
            else
                competence.Form = fakerArgs.Form;

            if (fakerArgs.Save)
                Save(competence);

            return competence;
        }

        public static void Save(Competence competence)
        {
            using var context = GetContext();
            context.ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
            context.Competences.Add(competence);
            context.SaveChanges();
        }

        public static void Update(Competence competence)
        {
            using var context = GetContext();
            context.Competences.Add(competence);
            context.SaveChanges();
        }

        public static void Remove(Competence competence, bool removeRelated = false)
        {
            using var context = GetContext();
            context.Competences.Remove(competence);
            context.SaveChanges();

            if (removeRelated)
            {
                if (competence.Form is not null)
                    Remove(competence.Form);
                else
                {
                    var form = context.Forms.Where(f => f.FormId == competence.FormId).FirstOrDefault();

                    if (form is not null)
                        Remove(form);
                }
            }
        }

        public static IEnumerable<Competence> CreateCompetences(CompetencesArgs? fakerArgs = null)
        {
            fakerArgs ??= new CompetencesArgs();
            using var context = new AssessmentContext();

            var competences = new List<Competence>(fakerArgs.Count);

            int id = fakerArgs.StartId;
            int count = fakerArgs.Count;
            while (count > 0)
            {
                competences.Add(CreateCompetence(new CompetenceArgs
                {
                    id = id,
                    Save = false,
                    Form = fakerArgs.Form,
                }));

                id = competences.Last().CompetenceId + 1;
                count--;
            }

            if (fakerArgs.Save)
                SaveRange(competences);

            return competences;
        }

        public static void SaveRange(IEnumerable<Competence> competences)
        {
            using var context = GetContext();
            context.Competences.AddRange(competences);
            context.SaveChanges();
        }

        public static void UpdateRange(IEnumerable<Competence> competences)
        {
            using var context = GetContext();
            context.Competences.AddRange(competences);
            context.SaveChanges();
        }

        public static void RemoveRange(IEnumerable<Competence> competences, bool removeRelated = false)
        {
            using var context = GetContext();
            context.RemoveRange(competences);
            context.SaveChanges();
            context.Dispose();

            if (removeRelated)
                competences
                    .GroupBy(c => c.Form)
                    .Select(c => c.FirstOrDefault())
                    .ToList()
                    .ForEach(c =>
                    {
                        if (c is not null)
                            Remove(c.Form);
                    });
        }
    }

    public partial class EntityFakerContained
    {
        public Container<Competence> CreateCompetence(CompetenceArgs? fakerArgs = null)
        {
            fakerArgs ??= new CompetenceArgs();
            fakerArgs.Save = false;

            var competence = EntityFaker.CreateCompetence(fakerArgs);
            return new Container<Competence>(competence,
                () => EntityFaker.Save(competence),
                () => EntityFaker.Update(competence),
                () => EntityFaker.Remove(competence, fakerArgs.RemoveRelated)
            );
        }

        public Container<IEnumerable<Competence>> CreateCompetences(CompetencesArgs? fakerArgs = null)
        {
            fakerArgs ??= new CompetencesArgs();
            fakerArgs.Save = false;

            var competences = EntityFaker.CreateCompetences(fakerArgs);
            return new Container<IEnumerable<Competence>>(competences,
                () => EntityFaker.SaveRange(competences),
                () => EntityFaker.UpdateRange(competences),
                () => EntityFaker.RemoveRange(competences, fakerArgs.RemoveRelated)
            );
        }
    }
}

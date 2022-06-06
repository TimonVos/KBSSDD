using Microsoft.EntityFrameworkCore;
using Model;
using Service.Database.EntityFaker.Args;

namespace Service.Database.EntityFaker
{
    public static partial class EntityFaker
    {
        public static Project CreateProject(ProjectArgs? fakerArgs = null)
        {
            fakerArgs ??= new ProjectArgs();
            var project = _projectFaker.Generate();
            project.Form = fakerArgs.Form;

            if (fakerArgs.Save)
                Save(project);

            return project;
        }

        public static void Save(Project project)
        {
            using var context = GetContext();
            if (project.Form.FormId != 0)
                context.Entry(project.Form).State = EntityState.Modified;
            context.Projects.Add(project);
            context.SaveChanges();
        }

        public static void Update(Project project)
        {
            using var context = GetContext();
            context.Projects.Add(project);
            context.SaveChanges();
        }

        public static void Remove(Project project, bool removeRelated = false)
        {
            using var context = GetContext();
            if (context.Projects.Any(p => p == project))
            {
                context.Projects.Remove(project);
                context.SaveChanges();
            }

            if (removeRelated)
            {
                if (project.Form is not null)
                    Remove(project.Form);
                else
                {
                    var form = context.Forms.Where(f => f.FormId == project.FormId).FirstOrDefault();

                    if (form is not null)
                        Remove(form);
                }
            }
        }

        public static IEnumerable<Project> CreateProjects(ProjectsArgs? fakerArgs = null)
        {
            fakerArgs ??= new ProjectsArgs();
            using var context = new AssessmentContext();

            var projects = new List<Project>(fakerArgs.Count);

            int id = fakerArgs.StartId;
            int count = fakerArgs.Count;
            while (count > 0)
            {
                projects.Add(CreateProject(new ProjectArgs
                {
                    id = id,
                    Save = false,
                    Form = fakerArgs.Form,
                }));

                id = projects.Last().ProjectId + 1;
                count--;
            }

            if (fakerArgs.Save)
                SaveRange(projects);

            return projects;
        }

        public static void SaveRange(IEnumerable<Project> projects)
        {
            using var context = GetContext();
            context.Projects.AddRange(projects);
            context.SaveChanges();
        }

        public static void UpdateRange(IEnumerable<Project> projects)
        {
            using var context = GetContext();
            context.Projects.AddRange(projects);
            context.SaveChanges();
        }

        public static void RemoveRange(IEnumerable<Project> projects, bool removeRelated = false)
        {
            using var context = GetContext();
            context.RemoveRange(projects);
            context.SaveChanges();
            context.Dispose();

            if (removeRelated)
                projects
                    .GroupBy(p => p.Form)
                    .Select(p => p.FirstOrDefault())
                    .ToList()
                    .ForEach(p =>
                    {
                        if (p is not null)
                            Remove(p.Form);
                    });
        }
    }

    public partial class EntityFakerContained
    {
        public Container<Project> CreateProject(ProjectArgs? fakerArgs = null)
        {
            fakerArgs ??= new ProjectArgs();
            fakerArgs.Save = false;

            var project = EntityFaker.CreateProject(fakerArgs);
            return new Container<Project>(project,
                () => EntityFaker.Save(project),
                () => EntityFaker.Update(project),
                () => EntityFaker.Remove(project, fakerArgs.RemoveRelated)
            );
        }

        public Container<IEnumerable<Project>> CreateProjects(ProjectsArgs? fakerArgs = null)
        {
            fakerArgs ??= new ProjectsArgs();
            fakerArgs.Save = false;

            var projects = EntityFaker.CreateProjects(fakerArgs);
            return new Container<IEnumerable<Project>>(projects,
                () => EntityFaker.SaveRange(projects),
                () => EntityFaker.UpdateRange(projects),
                () => EntityFaker.RemoveRange(projects, fakerArgs.RemoveRelated)
            );
        }
    }
}

using Service.Database;
using Service.Database.EntityFaker;
using Service.Database.EntityFaker.Args;

namespace Service.UnitTest.Database.EntityFakerTest.ModelTest
{
    [TestFixture]
    internal class ProjectTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void EntityFaker_can_create_a_project()
        {
            var projectA = EntityFaker.CreateProject(new ProjectArgs { Save = true });
            var projectB = EntityFaker.CreateProject(new ProjectArgs { Save = true });

            Assert.That(projectA.ProjectId, Is.Not.EqualTo(projectB.ProjectId));

            EntityFaker.RemoveRange(new[] { projectA, projectB }, true);
        }

        [Test]
        public void EntityFaker_can_create_projects()
        {
            var projectsA = EntityFaker.CreateProjects(new ProjectsArgs { Save = true });
            var projectsB = EntityFaker.CreateProjects(new ProjectsArgs { Save = true });

            var projectsT = projectsA.ToList();
            projectsT.AddRange(projectsB);
            Assert.That(projectsT.DistinctBy(p => p.ProjectId).Count, Is.EqualTo(projectsA.Count() + projectsB.Count()));

            EntityFaker.RemoveRange(projectsT, true);
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}

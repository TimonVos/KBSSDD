using Model;
using Service.Database;
using Service.Database.EntityFaker;

namespace Service.UnitTest.DatabaseTest.ModelTest
{
    [TestFixture]
    internal class ProjectTest
    {
        [SetUp]
        public void Setup()
        {
        }

        #region Assert attributes

        [Test]
        public void Project_name_is_required()
        {
            using var container = EntityFaker.Contained.CreateProject();

            container.Instance.Name = null!;
            DatabaseAssert.Throws(() => container.Save(), 515, nameof(container.Instance.Name));
        }

        [Test]
        public void Project_description_is_optional()
        {
            using var container = EntityFaker.Contained.CreateProject();

            container.Instance.Description = null!;
            Assert.DoesNotThrow(() => container.Save());
        }

        [Test]
        public void Project_code_is_required()
        {
            using var container = EntityFaker.Contained.CreateProject();

            container.Instance.Code = null!;
            DatabaseAssert.Throws(() => container.Save(), 515, nameof(container.Instance.Code));
        }

        #endregion

        #region Assert CRUD

        [Test]
        public void Project_can_be_created()
        {
            using var container = EntityFaker.Contained.CreateProject().Save();

            using var context = new AssessmentContext();
            Assert.That(context.Projects.Any(
                p => p.ProjectId == container.Instance.ProjectId
            ), Is.True);
        }

        [Test]
        public void Project_can_be_read()
        {
            using var container = EntityFaker.Contained.CreateProject().Save();

            using var context = new AssessmentContext();
            Project? project = (from p in context.Projects
                            where p.ProjectId == container.Instance.ProjectId
                            select p).FirstOrDefault();

            Assert.That(project, Is.Not.Null);
            Assert.Multiple(() =>
            {
                Assert.That(project.FormId, Is.EqualTo(container.Instance.FormId));
                Assert.That(project.Name, Is.EqualTo(container.Instance.Name));
                Assert.That(project.Description, Is.EqualTo(container.Instance.Description));
                Assert.That(project.Code, Is.EqualTo(container.Instance.Code));
            });
        }

        [Test]
        public void Project_can_be_updated()
        {
            using var container = EntityFaker.Contained.CreateProject().Save();

            AssessmentContext context;

            context = new AssessmentContext();
            Project? before = (from p in context.Projects
                             where p.ProjectId == container.Instance.ProjectId
                             select p).FirstOrDefault();

            var temp = EntityFaker.CreateProject();
            before!.Name = temp.Name;
            before!.Description = temp.Description;
            before!.Code = temp.Code;

            context.Projects.Update(before);
            context.SaveChanges();
            context.Dispose();

            context = new AssessmentContext();
            Project? after = (from p in context.Projects
                            where p.ProjectId == container.Instance.ProjectId
                            select p).FirstOrDefault();

            Assert.That(after, Is.Not.Null);
            Assert.Multiple(() =>
            {
                Assert.That(after.ProjectId, Is.EqualTo(before.ProjectId));
                Assert.That(after.FormId, Is.EqualTo(before.FormId));
                Assert.That(after.Name, Is.EqualTo(before.Name ));
                Assert.That(after.Description, Is.EqualTo(before.Description ));
                Assert.That(after.Code, Is.EqualTo(before.Code ));
            });
        }

        [Test]
        public void Project_can_be_deleted()
        {
            using var container = EntityFaker.Contained.CreateProject().Save();

            AssessmentContext context;

            context = new AssessmentContext();
            context.Projects.Remove(container.Instance);
            context.SaveChanges();
            context.Dispose();

            context = new AssessmentContext();
            Assert.That(context.Projects.Any(
                p => p.ProjectId == container.Instance.ProjectId
            ), Is.False);
        }

        #endregion

        #region Assert relationships

        [Test]
        public void Project_can_belong_to_forms()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void Project_can_have_assessments()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void Project_can_get_groups_from_assessments()
        {
            throw new NotImplementedException();
        }

        #endregion

        [TearDown]
        public void TearDown()
        {
        }
    }
}

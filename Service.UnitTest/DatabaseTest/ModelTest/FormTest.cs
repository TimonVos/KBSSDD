using Microsoft.EntityFrameworkCore;
using Model;
using Service.Database;
using Service.Database.EntityFaker;

namespace Service.UnitTest.DatabaseTest.ModelTest
{
    [TestFixture]
    internal class FormTest
    {
        [SetUp]
        public void Setup()
        {
        }

        #region Attributes

        [Test]
        public void Form_name_is_required()
        {
            using var container = EntityFaker.Contained.CreateStudent();

            container.Instance.Name = null!;
            DatabaseAssert.Throws(() => container.Save(), 515, "Name");
        }

        #endregion

        #region CRUD

        [Test]
        public void Form_can_be_created()
        {
            using var container = EntityFaker.Contained.CreateForm().Save();

            using var context = new AssessmentContext();
            Assert.That(context.Forms.Any(
                f => f.FormId == container.Instance.FormId
            ), Is.True);
        }

        [Test]
        public void Form_can_be_read()
        {
            using var container = EntityFaker.Contained.CreateForm().Save();

            using var context = new AssessmentContext();
            Form? form = (from f in context.Forms
                            where f.FormId == container.Instance.FormId
                            select f).FirstOrDefault();

            Assert.That(form, Is.Not.Null);
            Assert.Multiple(() =>
            {
                Assert.That(form.FormId, Is.EqualTo(container.Instance.FormId));
                Assert.That(form.Name, Is.EqualTo(container.Instance.Name));
            });
        }

        [Test]
        public void Form_can_be_updated()
        {
            using var container = EntityFaker.Contained.CreateForm().Save();

            AssessmentContext context;

            context = new AssessmentContext();
            Form? before = (from f in context.Forms
                             where f.FormId == container.Instance.FormId
                             select f).FirstOrDefault();

            var temp = EntityFaker.CreateForm();
            before!.Name = temp.Name;

            context.Forms.Update(before);
            context.SaveChanges();
            context.Dispose();

            context = new AssessmentContext();
            Form? after = (from f in context.Forms
                            where f.FormId == container.Instance.FormId
                            select f).FirstOrDefault();

            Assert.That(after, Is.Not.Null);
            Assert.Multiple(() =>
            {
                Assert.That(after.FormId, Is.EqualTo(before.FormId));
                Assert.That(after.Name, Is.EqualTo(before.Name));
            });
        }

        [Test]
        public void Form_can_be_deleted()
        {
            var container = EntityFaker.Contained.CreateForm().Save();

            AssessmentContext context;

            context = new AssessmentContext();
            context.Forms.Remove(container.Instance);
            context.SaveChanges();
            context.Dispose();

            context = new AssessmentContext();
            Assert.That(context.Forms.Any(
                f => f.FormId == container.Instance.FormId
            ), Is.False);
        }

        #endregion

        #region Relationships

        [Test]
        public void Form_can_belong_to_projects()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void Form_can_belong_to_competences()
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

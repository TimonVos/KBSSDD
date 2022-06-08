using Model;
using Service.Database;
using Service.Database.EntityFaker;
using Service.Database.EntityFaker.Args;

namespace Service.UnitTest.DatabaseTest.ModelTest
{
    [TestFixture]
    internal class RequirementTest
    {
        [SetUp]
        public void Setup()
        {
        }

        #region Assert attributes

        [Test]
        public void Requirement_name_is_optional()
        {
            using var container = EntityFaker.Contained.CreateRequirement();

            container.Instance.Name = null!;
            Assert.DoesNotThrow(() => container.Save());
        }

        [Test]
        public void Requirement_description_is_required()
        {
            using var container = EntityFaker.Contained.CreateRequirement();

            container.Instance.Description = null!;
            DatabaseAssert.Throws(() => container.Save(), 515, nameof(container.Instance.Description));
        }

        #endregion

        #region Assert CRUD

        [Test]
        public void Requirement_can_be_created()
        {
            using var container = EntityFaker.Contained.CreateRequirement().Save();

            using var context = new AssessmentContext();
            Assert.That(context.Requirements.Any(
                a => a.RequirementId == container.Instance.RequirementId
            ), Is.True);
        }

        [Test]
        public void Requirement_can_be_read()
        {
            using var container = EntityFaker.Contained.CreateRequirement().Save();

            using var context = new AssessmentContext();
            Requirement? requirement = (from r in context.Requirements
                                      where r.RequirementId == container.Instance.RequirementId
                                      select r).FirstOrDefault();

            Assert.That(requirement, Is.Not.Null);
            Assert.Multiple(() =>
            {
                Assert.That(requirement.RequirementId, Is.EqualTo(container.Instance.RequirementId));
            });
        }

        [Test]
        public void Requirement_can_be_updated()
        {
            using var container = EntityFaker.Contained.CreateRequirement().Save();

            AssessmentContext context;

            context = new AssessmentContext();
            Requirement? before = (from r in context.Requirements
                                  where r.RequirementId == container.Instance.RequirementId
                                  select r).FirstOrDefault();

            Assert.That(before, Is.Not.Null);
            var temp = EntityFaker.CreateRequirement();

            context.Requirements.Update(before);
            context.SaveChanges();
            context.Dispose();

            context = new AssessmentContext();
            Requirement? after = (from r in context.Requirements
                                 where r.RequirementId == container.Instance.RequirementId
                                 select r).FirstOrDefault();

            Assert.That(after, Is.Not.Null);
            Assert.Multiple(() =>
            {
                Assert.That(after.RequirementId, Is.EqualTo(before.RequirementId));
            });
        }

        [Test]
        public void Requirement_can_be_deleted()
        {
            using var container = EntityFaker.Contained.CreateRequirement().Save();

            AssessmentContext context;

            context = new AssessmentContext();
            context.Requirements.Remove(container.Instance);
            context.SaveChanges();
            context.Dispose();

            context = new AssessmentContext();
            Assert.That(context.Requirements.Any(
                r => r.RequirementId == container.Instance.RequirementId
            ), Is.False);
        }

        #endregion

        #region Assert relationships

        [Test]
        public void Requirement_can_have_criteria()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void Requirement_can_have_indicators()
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

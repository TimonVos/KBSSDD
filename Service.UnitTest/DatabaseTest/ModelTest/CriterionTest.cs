using Model;
using Service.Database;
using Service.Database.EntityFaker;

namespace Service.UnitTest.DatabaseTest.ModelTest
{
    [TestFixture]
    internal class CriterionTest
    {
        [SetUp]
        public void Setup()
        {
        }

        #region Attributes

        [Test]
        public void Criterion_name_is_optional()
        {
            using var container = EntityFaker.Contained.CreateCriterion();


            container.Instance.Name = null;
            Assert.DoesNotThrow(() => container.Save());
        }

        [Test]
        public void Criterion_description_is_required()
        {
            using var container = EntityFaker.Contained.CreateCriterion();

            container.Instance.Description = null!;
            DatabaseAssert.Throws(() => container.Save(), 515, nameof(container.Instance.Description));
        }

        #endregion

        #region CRUD

        [Test]
        public void Criterion_can_be_created()
        {
            using var container = EntityFaker.Contained.CreateCriterion().Save();

            using var context = new AssessmentContext();
            Assert.That(context.Criteria.Any(
                c => c.CriterionId == container.Instance.CriterionId
            ), Is.True);
        }

        [Test]
        public void Criterion_can_be_read()
        {
            using var container = EntityFaker.Contained.CreateCriterion().Save();

            using var context = new AssessmentContext();
            Criterion? competence = (from c in context.Criteria
                                      where c.CriterionId == container.Instance.CriterionId
                                      select c).FirstOrDefault();

            Assert.That(competence, Is.Not.Null);
            Assert.Multiple(() =>
            {
                Assert.That(competence.CriterionId, Is.EqualTo(container.Instance.CriterionId));
                Assert.That(competence.CompetenceId, Is.EqualTo(container.Instance.CompetenceId));
                Assert.That(competence.Name, Is.EqualTo(container.Instance.Name));
                Assert.That(competence.Description, Is.EqualTo(container.Instance.Description));
            });
        }

        [Test]
        public void Criterion_can_be_updated()
        {
            using var container = EntityFaker.Contained.CreateCriterion().Save();

            AssessmentContext context;

            context = new AssessmentContext();
            Criterion? before = (from c in context.Criteria
                                  where c.CriterionId == container.Instance.CriterionId
                                  select c).FirstOrDefault();

            var temp = EntityFaker.CreateCriterion();
            before!.Name = temp.Name;
            before!.Description = temp.Description;

            context.Criteria.Update(before);
            context.SaveChanges();
            context.Dispose();

            context = new AssessmentContext();
            Criterion? after = (from c in context.Criteria
                                 where c.CriterionId == container.Instance.CriterionId
                                 select c).FirstOrDefault();

            Assert.That(after, Is.Not.Null);
            Assert.Multiple(() =>
            {
                Assert.That(after.CriterionId, Is.EqualTo(before.CriterionId));
                Assert.That(after.CompetenceId, Is.EqualTo(before.CompetenceId));
                Assert.That(after.Name, Is.EqualTo(before.Name));
                Assert.That(after.Description, Is.EqualTo(before.Description));
            });
        }

        [Test]
        public void Criterion_can_be_deleted()
        {
            var container = EntityFaker.Contained.CreateCriterion().Save();

            AssessmentContext context;

            context = new AssessmentContext();
            context.Criteria.Remove(container.Instance);
            context.SaveChanges();
            context.Dispose();

            context = new AssessmentContext();
            Assert.That(context.Criteria.Any(
                c => c.CriterionId == container.Instance.CriterionId
            ), Is.False);
        }

        #endregion

        #region Relationships

        [Test]
        public void Criterion_can_belong_to_competences()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void Criterion_can_have_requirements()
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

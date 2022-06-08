using Model;
using Service.Database;
using Service.Database.EntityFaker;

namespace Service.UnitTest.DatabaseTest.ModelTest
{
    [TestFixture]
    internal class RatingTest
    {
        [SetUp]
        public void Setup()
        {
        }

        #region Assert attributes

        [Test]
        public void Rating_is_unique_per_assessment_and_criterion()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Assert CRUD

        [Test]
        public void Rating_can_be_created()
        {
            using var container = EntityFaker.Contained.CreateRating().Save();

            using var context = new AssessmentContext();
            Assert.That(context.Ratings.Any(r =>
                r.AssessmentId == container.Instance.AssessmentId &&
                r.CriterionId == container.Instance.CriterionId
            ), Is.True);
        }

        [Test]
        public void Rating_can_be_read()
        {
            using var container = EntityFaker.Contained.CreateRating().Save();

            using var context = new AssessmentContext();
            Rating? rating = (from r in context.Ratings
                              where r.AssessmentId == container.Instance.AssessmentId &&
                              r.CriterionId == container.Instance.CriterionId
                              select r).FirstOrDefault();

            Assert.That(rating, Is.Not.Null);
            Assert.Multiple(() =>
            {
                Assert.That(rating.AssessmentId, Is.EqualTo(container.Instance.AssessmentId));
                Assert.That(rating.CriterionId, Is.EqualTo(container.Instance.CriterionId));
                Assert.That(rating.RequirementId, Is.EqualTo(container.Instance.RequirementId));
            });
        }

        [Test]
        public void Rating_can_be_updated()
        {
            using var container = EntityFaker.Contained.CreateRating().Save();

            AssessmentContext context;

            context = new AssessmentContext();
            Rating? before = (from r in context.Ratings
                              where r.AssessmentId == container.Instance.AssessmentId &&
                              r.CriterionId == container.Instance.CriterionId
                              select r).FirstOrDefault();

            Assert.That(before, Is.Not.Null);
            var temp = EntityFaker.CreateRating();

            context.Ratings.Update(before);
            context.SaveChanges();
            context.Dispose();

            context = new AssessmentContext();
            Rating? after = (from r in context.Ratings
                             where r.AssessmentId == container.Instance.AssessmentId &&
                             r.CriterionId == container.Instance.CriterionId
                             select r).FirstOrDefault();

            Assert.That(after, Is.Not.Null);
            Assert.Multiple(() =>
            {
                Assert.That(after.AssessmentId, Is.EqualTo(before.AssessmentId));
                Assert.That(after.CriterionId, Is.EqualTo(before.CriterionId));
                Assert.That(after.RequirementId, Is.EqualTo(before.RequirementId));
            });
        }

        [Test]
        public void Rating_can_be_deleted()
        {
            using var container = EntityFaker.Contained.CreateRating().Save();

            AssessmentContext context;

            context = new AssessmentContext();
            context.Ratings.Remove(container.Instance);
            context.SaveChanges();
            context.Dispose();

            context = new AssessmentContext();
            Assert.That(context.Ratings.Any(r =>
                r.AssessmentId == container.Instance.AssessmentId &&
                r.CriterionId == container.Instance.CriterionId
            ), Is.False);
        }

        #endregion

        #region Assert relationships

        [Test]
        public void Rating_can_have_an_assessment()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void Rating_can_have_a_criterion()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void Rating_can_have_a_requirement()
        {
            throw new NotImplementedException();
        }


        [Test]
        public void Rating_can_get_the_indicator_from_its_criterion()
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

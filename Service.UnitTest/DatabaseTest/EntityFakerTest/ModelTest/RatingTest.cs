using Service.Database;
using Service.Database.EntityFaker;
using Service.Database.EntityFaker.Args;

namespace Service.UnitTest.Database.EntityFakerTest.ModelTest
{
    [TestFixture]
    internal class RatingTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void EntityFaker_can_create_a_rating()
        {
            var ratingA = EntityFaker.CreateRating(new RatingArgs { Save = true });
            var ratingB = EntityFaker.CreateRating(new RatingArgs { Save = true });

            Assert.That(ratingA.AssessmentId, Is.Not.EqualTo(ratingB.AssessmentId));
            Assert.That(ratingA.CriterionId, Is.Not.EqualTo(ratingB.CriterionId));

            EntityFaker.RemoveRange(new[] { ratingA, ratingB }, true);
        }

        [Test]
        public void EntityFaker_can_create_ratings()
        {
            var ratingsA = EntityFaker.CreateRatings(new RatingsArgs { Save = true });
            var ratingsB = EntityFaker.CreateRatings(new RatingsArgs { Save = true });

            var ratingsT = ratingsA.ToList();
            ratingsT.AddRange(ratingsB);
            Assert.That(ratingsT.DistinctBy(r => new { r.Assessment, r.Criterion }).Count, Is.EqualTo(ratingsA.Count() + ratingsB.Count()));

            EntityFaker.RemoveRange(ratingsT, true);
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}

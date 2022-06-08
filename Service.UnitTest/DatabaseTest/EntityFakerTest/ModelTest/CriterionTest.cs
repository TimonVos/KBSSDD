using Service.Database;
using Service.Database.EntityFaker;
using Service.Database.EntityFaker.Args;

namespace Service.UnitTest.Database.EntityFakerTest.ModelTest
{
    [TestFixture]
    internal class CriteriaTest
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void EntityFaker_can_create_a_criterion()
        {
            var criterionA = EntityFaker.CreateCriterion(new CriterionArgs { Save = true });
            var criterionB = EntityFaker.CreateCriterion(new CriterionArgs { Save = true });

            Assert.That(criterionA.CompetenceId, Is.Not.EqualTo(criterionB.CompetenceId));

            EntityFaker.RemoveRange(new[] { criterionA, criterionB }, true);
        }

        [Test]
        public void EntityFaker_can_create_criteria()
        {
            var criteriaA = EntityFaker.CreateCriteria(new CriteriaArgs { Save = true });
            var criteriaB = EntityFaker.CreateCriteria(new CriteriaArgs { Save = true });

            var criteriaT = criteriaA.ToList();
            criteriaT.AddRange(criteriaB);
            Assert.That(criteriaT.DistinctBy(c => c.CriterionId).Count, Is.EqualTo(criteriaA.Count() + criteriaB.Count()));

            EntityFaker.RemoveRange(criteriaT, true);
        }

        [TearDown]
        public void TearDown()
        {
        }
    }
}

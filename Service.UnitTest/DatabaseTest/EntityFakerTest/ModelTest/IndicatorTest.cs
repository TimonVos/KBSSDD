using Service.Database.EntityFaker;

namespace Service.UnitTest.Database.EntityFakerTest.ModelTest
{
    [TestFixture]
    internal class IndicatorTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void EntityFaker_can_create_an_indicator()
        {
            var indicatorA = EntityFaker.CreateIndicator(new FakerArgs { Save = true });
            var indicatorB = EntityFaker.CreateIndicator(new FakerArgs { Save = true });

            Assert.That(indicatorA.IndicatorId, Is.Not.EqualTo(indicatorB.IndicatorId));

            EntityFaker.RemoveRange(new[] { indicatorA, indicatorB });
        }

        [Test]
        public void EntityFaker_can_create_indicators()
        {
            var indicatorsA = EntityFaker.CreateIndicators(new EnumerableFakerArgs { Save = true });
            var indicatorsB = EntityFaker.CreateIndicators(new EnumerableFakerArgs { Save = true });

            var groupsT = indicatorsA.ToList();
            groupsT.AddRange(indicatorsB);
            Assert.That(groupsT.DistinctBy(i => i.IndicatorId).Count, Is.EqualTo(indicatorsA.Count() + indicatorsB.Count()));

            EntityFaker.RemoveRange(groupsT);
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}

using Service.Database;
using Service.Database.EntityFaker;
using Service.Database.EntityFaker.Args;

namespace Service.UnitTest.Database.EntityFakerTest.ModelTest
{
    [TestFixture]
    internal class RequirementTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void EntityFaker_can_create_a_requirement()
        {
            var requirementA = EntityFaker.CreateRequirement(new RequirementArgs { Save = true });
            var requirementB = EntityFaker.CreateRequirement(new RequirementArgs { Save = true });

            Assert.That(requirementA.RequirementId, Is.Not.EqualTo(requirementB.RequirementId));

            EntityFaker.RemoveRange(new[] { requirementA, requirementB }, true);
        }

        [Test]
        public void EntityFaker_can_create_requirements()
        {
            var requirementsA = EntityFaker.CreateRequirements(new RequirementsArgs { Save = true });
            var requirementsB = EntityFaker.CreateRequirements(new RequirementsArgs { Save = true });

            var requirementsT = requirementsA.ToList();
            requirementsT.AddRange(requirementsB);
            Assert.That(requirementsT.DistinctBy(p => p.RequirementId).Count, Is.EqualTo(requirementsA.Count() + requirementsB.Count()));

            EntityFaker.RemoveRange(requirementsT, true);
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}

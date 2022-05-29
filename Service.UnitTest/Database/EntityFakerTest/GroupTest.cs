using Service.Database.EntityFaker;
using Service.Database.EntityFaker.Faker;

namespace Service.UnitTest.Database.EntityFakerTest
{
    [TestFixture]
    internal class GroupTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void EntityFaker_can_create_a_group()
        {
            var groupA = EntityFaker.CreateGroup(new FakerArgs { Save = true });
            var groupB = EntityFaker.CreateGroup(new FakerArgs { Save = true });

            Assert.That(groupA.GroupId, Is.Not.EqualTo(groupB.GroupId));

            EntityFaker.RemoveGroups(new[] { groupA, groupB });
        }

        [Test]
        public void EntityFaker_can_create_groups()
        {
            var groupsA = EntityFaker.CreateGroups(new EnumerableFakerArgs { Save = true });
            var groupsB = EntityFaker.CreateGroups(new EnumerableFakerArgs { Save = true });

            var groupsT = groupsA.ToList();
            groupsT.AddRange(groupsB);
            Assert.That(groupsT.DistinctBy(s => s.GroupId).Count, Is.EqualTo(groupsA.Count() + groupsB.Count()));

            EntityFaker.RemoveGroups(groupsT);
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}

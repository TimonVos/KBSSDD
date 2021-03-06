using Service.Database.EntityFaker;

namespace Service.UnitTest.Database.EntityFakerTest.ModelTest
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

            EntityFaker.RemoveRange(new[] { groupA, groupB });
        }

        [Test]
        public void EntityFaker_can_create_groups()
        {
            var groupsA = EntityFaker.CreateGroups(new EnumerableFakerArgs { Save = true });
            var groupsB = EntityFaker.CreateGroups(new EnumerableFakerArgs { Save = true });

            var groupsT = groupsA.ToList();
            groupsT.AddRange(groupsB);
            Assert.That(groupsT.DistinctBy(g => g.GroupId).Count, Is.EqualTo(groupsA.Count() + groupsB.Count()));

            EntityFaker.RemoveRange(groupsT);
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}

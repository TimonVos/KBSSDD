using Service.Database.EntityFaker;
using Service.Database.EntityFaker.Faker;

namespace Service.UnitTest.Database.EntityFakerTest.ScenarioTest
{
    [TestFixture]
    internal class GroupsWithStudentsScenarioTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void EntityFaker_can_create_a_groups_with_students_scenario()
        {
            var scenario = EntityFaker.CreateScenario_GroupsWithStudents(new GroupsWithStudentsArgs());
            scenario.Save();
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}

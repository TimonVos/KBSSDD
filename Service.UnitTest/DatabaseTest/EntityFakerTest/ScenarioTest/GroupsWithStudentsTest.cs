using Service.Database;
using Service.Database.EntityFaker;

namespace Service.UnitTest.Database.EntityFakerTest.ScenarioTest
{
    [TestFixture]
    internal class GroupsWithStudentsTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void EntityFaker_can_create_a_groups_with_students_scenario()
        {
            using var scenario = EntityFaker.CreateScenario_GroupsWithStudents(new GroupsWithStudentsArgs()).Save();

            AssertScenario(scenario);
        }

        [Test]
        public void EntityFaker_can_create_a_group_with_students_scenario_with_empty_groups()
        {
            using var scenario = EntityFaker.CreateScenario_GroupsWithStudents(new GroupsWithStudentsArgs
            {
                groupsArgs = new EnumerableFakerArgs { Count = 10 },
                studentsArgs = new EnumerableFakerArgs { Count = 1 },
                AllowEmptyGroups = true,
                MaxStudentsPerGroup = 1,
            }).Save();

            var context = new AssessmentContext();

            Assert.That(context.Groups.Any(g => g.Students.Count == 0), Is.True);
            AssertScenario(scenario, context);
        }

        [Test]
        public void EntityFaker_can_create_a_group_with_students_scenario_without_empty_groups()
        {
            using var scenario = EntityFaker.CreateScenario_GroupsWithStudents(new GroupsWithStudentsArgs
            {
                groupsArgs = new EnumerableFakerArgs { Count = 10 },
                studentsArgs = new EnumerableFakerArgs { Count = 1 },
                AllowEmptyGroups = false,
                MaxStudentsPerGroup = 1,
            }).Save();

            var context = new AssessmentContext();

            Assert.That(context.Groups.Any(g => g.Students.Count == 0), Is.False);
            AssertScenario(scenario, context);
        }

        private void AssertScenario(GroupsWithStudentsScenario scenario, AssessmentContext? context = null)
        {
            context ??= new AssessmentContext();

            scenario.Groups.ToList().ForEach(g =>
                Assert.That(context.Groups.ToList().Exists(
                    cg => cg.GroupId == g.GroupId),
                    Is.True
                ));

            scenario.Students.ToList().ForEach(s =>
                Assert.That(context.Students.ToList().Exists(
                    cs => cs.StudentNumber == s.StudentNumber),
                    Is.True
                ));

            scenario.GroupStudents.ToList().ForEach(gs =>
                Assert.That(context.GroupStudents.ToList().Exists(
                    cgs => cgs.StudentNumber == gs.StudentNumber && cgs.GroupId == gs.GroupId),
                    Is.True
                ));
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}

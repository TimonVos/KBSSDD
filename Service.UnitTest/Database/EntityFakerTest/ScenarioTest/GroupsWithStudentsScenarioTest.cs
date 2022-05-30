﻿using Service.Database;
using Service.Database.EntityFaker;

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
            var scenario = EntityFaker.CreateScenario_GroupsWithStudents(new GroupsWithStudentsArgs()).Save();

            using var context = new AssessmentContext();

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

            scenario.Remove();
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}
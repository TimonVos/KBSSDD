using Microsoft.EntityFrameworkCore;
using Model;
using Service.Database;
using Service.Database.EntityFaker;

namespace Service.UnitTest.DatabaseTest.ModelTest
{
    [TestFixture]
    internal class GroupTest
    {
        [SetUp]
        public void Setup()
        {
        }

        #region Attributes

        [Test]
        public void Group_name_is_optional()
        {
            using var container = EntityFaker.Contained.CreateGroup();

            container.Instance.Name = null;
            Assert.DoesNotThrow(() => container.Save());
        }

        #endregion

        #region CRUD

        [Test]
        public void Group_can_be_created()
        {
            using var container = EntityFaker.Contained.CreateGroup().Save();

            using var context = new AssessmentContext();
            Assert.That(context.Groups.Any(
                g => g.GroupId == container.Instance.GroupId
            ), Is.True);
        }

        [Test]
        public void Group_can_be_read()
        {
            using var container = EntityFaker.Contained.CreateGroup().Save();

            using var context = new AssessmentContext();
            Group? group = (from g in context.Groups
                            where g.GroupId == container.Instance.GroupId
                            select g).FirstOrDefault();

            Assert.That(group, Is.Not.Null);
            Assert.Multiple(() =>
            {
                Assert.That(group.GroupId, Is.EqualTo(container.Instance.GroupId));
                Assert.That(group.Number, Is.EqualTo(container.Instance.Number));
                Assert.That(group.Name, Is.EqualTo(container.Instance.Name));
            });
        }

        [Test]
        public void Group_can_be_updated()
        {
            using var container = EntityFaker.Contained.CreateGroup().Save();

            AssessmentContext context;

            context = new AssessmentContext();
            Group? before = (from g in context.Groups
                             where g.GroupId == container.Instance.GroupId
                             select g).FirstOrDefault();

            var temp = EntityFaker.CreateGroup();
            before!.Name = temp.Name;
            before!.Number = temp.Number;

            context.Groups.Update(before);
            context.SaveChanges();
            context.Dispose();

            context = new AssessmentContext();
            Group? after = (from g in context.Groups
                            where g.GroupId == container.Instance.GroupId
                            select g).FirstOrDefault();

            Assert.That(after, Is.Not.Null);
            Assert.Multiple(() =>
            {
                Assert.That(after.GroupId, Is.EqualTo(before.GroupId));
                Assert.That(after.Number, Is.EqualTo(before.Number));
                Assert.That(after.Name, Is.EqualTo(before.Name));
            });
        }

        [Test]
        public void Group_can_be_deleted()
        {
            var container = EntityFaker.Contained.CreateGroup().Save();

            AssessmentContext context;

            context = new AssessmentContext();
            context.Groups.Remove(container.Instance);
            context.SaveChanges();
            context.Dispose();

            context = new AssessmentContext();
            Assert.That(context.Groups.Any(
                g => g.GroupId == container.Instance.GroupId
            ), Is.False);
        }

        #endregion

        #region Relationships

        [Test]
        public void Group_can_have_students()
        {
            using var scenario = EntityFaker.CreateScenario_GroupsWithStudents(
                new GroupsWithStudentsArgs
                {
                    groupsArgs = new EnumerableFakerArgs { Count = 1 },
                    AllowEmptyGroups = false,
                }).Save();

            using var context = new AssessmentContext();

            var group = scenario.Groups.First();
            foreach (var student in scenario.Students)
            {
                var s = context.Students
                    .Where(s => s.StudentNumber == student.StudentNumber)
                    .Include(s => s.Groups)
                    .FirstOrDefault();

                Assert.That(s, Is.Not.Null);
                if (student.Groups.Any(g => g.GroupId == group.GroupId))
                    Assert.That(s.Groups.Any(
                        g => g.GroupId == group.GroupId
                    ), Is.True);
            }
        }

        [Test]
        public void Group_can_have_assessments()
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

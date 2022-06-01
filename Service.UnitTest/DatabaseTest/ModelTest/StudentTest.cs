using Microsoft.EntityFrameworkCore;
using Model;
using Service.Database;
using Service.Database.EntityFaker;

namespace Service.UnitTest.DatabaseTest.ModelTest
{
    [TestFixture]
    internal class StudentTest
    {
        [SetUp]
        public void Setup()
        {
        }

        #region Attributes

        [Test]
        public void Student_stduent_number_is_unique()
        {
            using var unique = EntityFaker.Contained.CreateStudent().Save();
            using var container = EntityFaker.Contained.CreateStudent();

            container.Instance.StudentNumber = unique.Instance.StudentNumber;

            DatabaseAssert.Throws(() => container.Save(), 2627, "Cannot insert duplicate key");
        }

        [Test]
        public void Student_name_is_required()
        {
            using var container = EntityFaker.Contained.CreateStudent();

            container.Instance.Name = null!;
            DatabaseAssert.Throws(() => container.Save(), 515, nameof(container.Instance.Name));
        }

        #endregion

        #region CRUD

        [Test]
        public void Student_can_be_created()
        {
            using var container = EntityFaker.Contained.CreateStudent().Save();

            using var context = new AssessmentContext();
            Assert.That(context.Students.Any(
                s => s.StudentNumber == container.Instance.StudentNumber
            ), Is.True);
        }

        [Test]
        public void Student_can_be_read()
        {
            using var container = EntityFaker.Contained.CreateStudent().Save();

            using var context = new AssessmentContext();
            Student? student = (from s in context.Students
                                where s.StudentNumber == container.Instance.StudentNumber
                                select s).FirstOrDefault();

            Assert.That(student, Is.Not.Null);
            Assert.Multiple(() =>
            {
                Assert.That(student.StudentNumber, Is.EqualTo(container.Instance.StudentNumber));
                Assert.That(student.Name, Is.EqualTo(container.Instance.Name));
            });
        }

        [Test]
        public void Student_can_be_updated()
        {
            using var container = EntityFaker.Contained.CreateStudent().Save();

            AssessmentContext context;

            context = new AssessmentContext();
            Student? before = (from s in context.Students
                               where s.StudentNumber == container.Instance.StudentNumber
                               select s).FirstOrDefault();

            var temp = EntityFaker.CreateStudent();
            before!.Name = temp.Name;

            context.Students.Update(before);
            context.SaveChanges();
            context.Dispose();

            context = new AssessmentContext();
            Student? after = (from s in context.Students
                              where s.StudentNumber == container.Instance.StudentNumber
                              select s).FirstOrDefault();

            Assert.That(after, Is.Not.Null);
            Assert.Multiple(() =>
            {
                Assert.That(after.StudentNumber, Is.EqualTo(before.StudentNumber));
                Assert.That(after.Name, Is.EqualTo(before.Name));
            });
        }

        [Test]
        public void Student_can_be_deleted()
        {
            var container = EntityFaker.Contained.CreateStudent().Save();

            AssessmentContext context;

            context = new AssessmentContext();
            context.Students.Remove(container.Instance);
            context.SaveChanges();
            context.Dispose();

            context = new AssessmentContext();
            Assert.That(context.Students.Any(
                s => s.StudentNumber == container.Instance.StudentNumber
            ), Is.False);
        }

        #endregion

        #region Relationships

        [Test]
        public void Student_can_have_groups()
        {
            using var scenario = EntityFaker.CreateScenario_GroupsWithStudents(
                new GroupsWithStudentsArgs
                {
                    studentsArgs = new EnumerableFakerArgs { Count = 1 },
                    AllowEmptyGroups = false,
                }).Save();

            using var context = new AssessmentContext();

            var student = scenario.Students.First();
            foreach (var group in scenario.Groups)
            {
                var g = context.Groups
                    .Where(g => g.GroupId == group.GroupId)
                    .Include(g => g.Students)
                    .FirstOrDefault();

                Assert.That(g, Is.Not.Null);
                if (group.Students.Any(s => s.StudentNumber == student.StudentNumber))
                    Assert.That(g.Students.Any(
                        s => s.StudentNumber == scenario.Students.First().StudentNumber
                    ), Is.True);
            }
        }

        #endregion

        [TearDown]
        public void TearDown()
        {
        }
    }
}

using Service.Database.EntityFaker;
using Service.Database.EntityFaker.Core;

namespace Service.UnitTest.Database.EntityFakerTest.ModelTest
{
    [TestFixture]
    internal class StudentTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void EntityFaker_can_create_a_unique_student()
        {
            var studentA = EntityFaker.CreateStudent(new FakerArgs { Save = true });
            var studentB = EntityFaker.CreateStudent(new FakerArgs { Save = true });

            Assert.That(studentA.StudentNumber, Is.Not.EqualTo(studentB.StudentNumber));

            EntityFaker.RemoveStudents(new[] { studentA, studentB });
        }

        [Test]
        public void EntityFaker_can_create_unique_students()
        {
            var studentsA = EntityFaker.CreateStudents(new EnumerableFakerArgs { Save = true });
            var studentsB = EntityFaker.CreateStudents(new EnumerableFakerArgs { Save = true });

            var studentsT = studentsA.ToList();
            studentsT.AddRange(studentsB);
            Assert.That(studentsT.DistinctBy(s => s.StudentNumber).Count, Is.EqualTo(studentsA.Count() + studentsB.Count()));

            EntityFaker.RemoveStudents(studentsT);
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}

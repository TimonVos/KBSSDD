using Model;
using Service.Database.EntityFaker.Faker;

namespace Service.Database.EntityFaker
{
    public static class EntityFaker
    {
        public static Bogus.Faker Faker { get; }
        private static readonly Bogus.Faker<Student> _studentFaker;

        static EntityFaker()
        {
            Faker = new Bogus.Faker();

            _studentFaker = new Bogus.Faker<Student>()
                .RuleFor(f => f.Name, f => f.Name.FullName());
        }

        public static Student CreateStudent(FakerArgs fakerArgs)
        {
            using var context = new AssessmentContext();

            while (context.Students.Any(s => s.StudentNumber == fakerArgs.id))
                fakerArgs.id++;

            var student = _studentFaker.Generate();
            student.StudentNumber = fakerArgs.id;

            if (fakerArgs.Save)
            {
                context.Students.Add(student);
                context.SaveChanges();
            }

            return student;
        }

        public static void RemoveStudent(Student student)
        {
            using var context = new AssessmentContext();
            context.Students.Remove(student);
            context.SaveChanges();
        }

        public static IEnumerable<Student> CreateStudents(EnumerableFakerArgs fakerArgs)
        {
            using var context = new AssessmentContext();

            var students = new List<Student>(fakerArgs.Count);

            int id = fakerArgs.StartId;
            int count = fakerArgs.Count;
            while (count > 0)
            {
                students.Add(CreateStudent(new FakerArgs {
                    id = id,
                    Save = false,
                }));

                id = students.Last().StudentNumber + 1;
                count--;
            }

            if (fakerArgs.Save)
            {
                context.Students.AddRange(students);
                context.SaveChanges();
            }

            return students;
        }

        public static void RemoveStudents(IEnumerable<Student> students)
        {
            using var context = new AssessmentContext();
            context.Students.RemoveRange(students);
            context.SaveChanges();
        }
    }
}

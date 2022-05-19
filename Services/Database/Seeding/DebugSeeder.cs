#if DEBUG
using Microsoft.EntityFrameworkCore;
using Model;

namespace Service.Database.Seeding
{
    /// <summary>
    /// Seed the database with random data.
    /// </summary>
    public class DebugSeeder : SeederBase
    {
        public override void Seed(ModelBuilder modelBuilder)
        {
            var groupsCount = Faker.RandomNumber.Next(10, 40);
            var studentsCount = Faker.RandomNumber.Next(60, 240);

            var groups = Groups(modelBuilder, groupsCount);
            var students = Students(modelBuilder, studentsCount);
            GroupStudents(modelBuilder, groups, students);
        }

        /// <summary>
        /// Adds seed data to <see cref="Group"/> and returns it as <see cref="List{T}"/>.
        /// </summary>
        /// <remarks>
        /// </remarks>
        /// <param name="modelBuilder"></param>
        /// <param name="groupsCount">Number of groups to generate</param>
        /// <returns><see cref="List{T}}"/> containing <see cref="Group"/> elements.</returns>
        private static List<Group> Groups(ModelBuilder modelBuilder, int groupsCount = 4)
        {
            var groups = new List<Group>();

            for (var i = 1; i < groupsCount; i++)
                groups.Add(new Group { GroupId = i, Name = Faker.Company.Name(), Number = Faker.RandomNumber.Next(1, 6) });

            modelBuilder.Entity<Group>().HasData(groups);

            return groups;
        }

        /// <summary>
        /// Adds seed data to <see cref="Student"/> and returns it as <see cref="List{T}"/>.
        /// </summary>
        /// <param name="modelBuilder"></param>
        /// <param name="studentsCount"></param>
        /// <returns><see cref="List{T}}"/> containing <see cref="Student"/> elements.</returns>
        private static List<Student> Students(ModelBuilder modelBuilder, int studentsCount = 24)
        {
            (int Min, int Max) studentNumberRange = (115000, 115000 + studentsCount * 5);
            var students = new List<Student>();
            var studentNumbers = new List<int>();

            for (var i = 0; i < studentsCount; i++)
            {
                int studentNumber;
                do studentNumber = Faker.RandomNumber.Next(studentNumberRange.Min, studentNumberRange.Max);
                while (studentNumbers.Contains(studentNumber));
                studentNumbers.Add(studentNumber);
            }

            foreach (var number in studentNumbers)
                students.Add(new Student { StudentNumber = number, Name = Faker.Name.FullName() });

            modelBuilder.Entity<Student>().HasData(students);

            return students;
        }

        /// <summary>
        /// Adds seed data to <see cref="GroupStudent"/> join.
        /// </summary>
        /// <param name="modelBuilder"></param>
        /// <param name="groups"><see cref="List{T}"/> of <see cref="Group"/> to use.</param>
        /// <param name="students"></param>
        private static void GroupStudents(ModelBuilder modelBuilder, List<Group> groups, List<Student> students)
        {
            var groupStudents = new List<GroupStudent>();

            foreach (var group in groups)
            {
                var currentStudents = new List<Student>();
                var groupSize = Faker.RandomNumber.Next(2, 8);

                for (var i = 0; i < groupSize; i++)
                {
                    Student student;
                    do student = students[Faker.RandomNumber.Next(0, students.Count() - 1)];
                    while (currentStudents.Contains(student));
                    currentStudents.Add(student);
                }

                foreach (var student in currentStudents)
                    groupStudents.Add(new GroupStudent { GroupId = group.GroupId, StudentNumber = student.StudentNumber });
            }

            modelBuilder.Entity<GroupStudent>().HasData(groupStudents);
        }
    }
}
#endif

#if DEBUG
using Bogus;
using Microsoft.EntityFrameworkCore;
using Model;

namespace Service.Database.Seeding
{
    /// <summary>
    /// Seed the database with random data.
    /// </summary>
    public class DebugSeeder : SeederBase
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="modelBuilder"></param>
        public override void Seed(ModelBuilder modelBuilder)
        {
            var groups = Groups(modelBuilder, Faker.Random.Number(10, 40));
            var students = Students(modelBuilder, Faker.Random.Number(60, 240));
            GroupStudents(modelBuilder, groups, students);
            var indicators = Indicators(modelBuilder, Faker.Random.Number(3, 9));

        }

        /// <summary>
        /// Adds seed data to <see cref="Group"/> and returns it as <see cref="List{T}"/>.
        /// </summary>
        /// <param name="modelBuilder"></param>
        /// <param name="groupsCount">Number of groups to generate</param>
        /// <returns><see cref="List{T}}"/> containing <see cref="Group"/> elements.</returns>
        private List<Group> Groups(ModelBuilder modelBuilder, int groupsCount = 4)
        {
            var groups = new List<Group>();

            for (var i = 1; i <= groupsCount; i++)
                groups.Add(new Group { GroupId = i, Name = Faker.Company.CompanyName(), Number = Faker.Random.Number(1, 6) });

            modelBuilder.Entity<Group>().HasData(groups);

            return groups;
        }

        /// <summary>
        /// Adds seed data to <see cref="Student"/> and returns it as <see cref="List{T}"/>.
        /// </summary>
        /// <param name="modelBuilder"></param>
        /// <param name="studentsCount"></param>
        /// <returns><see cref="List{T}}"/> containing <see cref="Student"/> elements.</returns>
        private List<Student> Students(ModelBuilder modelBuilder, int studentsCount = 24)
        {
            (int Min, int Max) studentNumberRange = (115000, 115000 + studentsCount * 5);
            var students = new List<Student>();
            var studentNumbers = new List<int>();

            for (var i = 0; i < studentsCount; i++)
            {
                int studentNumber;
                do studentNumber = Faker.Random.Number(studentNumberRange.Min, studentNumberRange.Max);
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
        private void GroupStudents(ModelBuilder modelBuilder, List<Group> groups, List<Student> students)
        {
            var groupStudents = new List<GroupStudent>();

            foreach (var group in groups)
            {
                var currentStudents = new List<Student>();
                var groupSize = Faker.Random.Number(2, 8);

                for (var i = 0; i < groupSize; i++)
                {
                    Student student;
                    do student = students[Faker.Random.Number(0, students.Count() - 1)];
                    while (currentStudents.Contains(student));
                    currentStudents.Add(student);
                }

                foreach (var student in currentStudents)
                    groupStudents.Add(new GroupStudent { GroupId = group.GroupId, StudentNumber = student.StudentNumber });
            }

            modelBuilder.Entity<GroupStudent>().HasData(groupStudents);
        }

        /// <summary>
        /// Adds seed data to <see cref="Indicator"/>.
        /// </summary>
        /// <param name="modelBuilder"></param>
        /// <param name="indicatorsCount">Number of indicators to generate</param>
        private List<Indicator> Indicators(ModelBuilder modelBuilder, int indicatorsCount)
        {
            var indicators = new List<Indicator>();

            for (var i = 1; i <= indicatorsCount; i++)
                indicators.Add(new Indicator { IndicatorId = i, Name = Faker.Random.Word(), Value = Faker.Random.Number(1, 10) });

            modelBuilder.Entity<Indicator>().HasData(indicators);

            return indicators;
        }
    }
}
#endif

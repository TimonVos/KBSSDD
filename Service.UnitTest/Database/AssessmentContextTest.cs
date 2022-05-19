using Microsoft.EntityFrameworkCore;
using Model;
using Service.Database;

namespace Service.UnitTest.Database
{
    /// <summary>
    /// Test the Entity Framework for:
    /// <list type="bullet">
    ///   <item>CRUD (Create, Read, Update and Delete) capabilities</item>
    ///   <item>One to one, one to many and many to many relationships</item>
    /// </list>
    /// 
    /// </summary>
    public class AssessmentContextTest
    {
        /// <summary>
        /// Holds the temporary instance of a model for CRUD testing.
        /// </summary>
        private Group? _group;
        private List<Student> _students;
        private List<Group> _groups;

        [SetUp]
        public void Setup()
        {
            using var context = new AssessmentContext();
            var studentNumber = (context.Students.Max(s => (int?)s.StudentNumber) ?? 1) + 1;

            _students = new List<Student>
            {
                new Student { Name = Faker.Name.FullName(), StudentNumber = studentNumber++ },
                new Student { Name = Faker.Name.FullName(), StudentNumber = studentNumber++ },
                new Student { Name = Faker.Name.FullName(), StudentNumber = studentNumber++ },
                new Student { Name = Faker.Name.FullName(), StudentNumber = studentNumber++ },
                new Student { Name = Faker.Name.FullName(), StudentNumber = studentNumber++ },
            };

            _groups = new List<Group>
            {
                new Group { Name = Faker.Company.Name(), Number = Faker.RandomNumber.Next(1, 6) },
                new Group { Name = Faker.Company.Name(), Number = Faker.RandomNumber.Next(1, 6) },
                new Group { Name = Faker.Company.Name(), Number = Faker.RandomNumber.Next(1, 6) },
            };

            _students.ForEach(s => context.Add(s));
            _groups.ForEach(g => context.Add(g));
            context.SaveChanges();

            _groups[0].Students.Add(_students[0]);
            _groups[0].Students.Add(_students[1]);
            _groups[1].Students.Add(_students[2]);
            _groups[1].Students.Add(_students[3]);

            context.Groups.Update(_groups[0]);
            context.Groups.Update(_groups[1]);
            context.SaveChanges();
        }

        /// <summary>
        /// Tests whether Entity Framework can create an instance of a modal.
        /// </summary>
        [Test, Order(1), NonParallelizable]
        public void AssessmentContext_CanCreate()
        {
            using var context = new AssessmentContext();

            context.Add(new Group { Name = Faker.Company.Name(), Number = Faker.RandomNumber.Next(1, 6) });
            context.SaveChanges();

            Group? group = context.Groups
                .OrderByDescending(g => g.GroupId)
                .FirstOrDefault();

            Assert.IsNotNull(group);

            if (group is not null)
                _group = group;
        }

        /// <summary>
        /// Tests whether Entity Framework can read an instance of a modal.
        /// </summary>
        [Test, Order(2), NonParallelizable]
        public void AssessmentContext_CanRead()
        {
            using var context = new AssessmentContext();

            if (_group is null)
            {
                Assert.Fail("Test model instance is null");
                return;
            }

            Group? group = context.Groups
                .Where(g => g.GroupId == _group.GroupId)
                .FirstOrDefault();

            Assert.IsNotNull(group);
            Assert.That(group.Name, Is.EqualTo(_group?.Name));
        }

        /// <summary>
        /// Tests whether Entity Framework can update an instance of a modal.
        /// </summary>
        [Test, Order(3), NonParallelizable]

        public void AssessmentContext_CanUpdate()
        {
            using var context = new AssessmentContext();

            if (_group is null)
            {
                Assert.Fail("Test model instance is null");
                return;
            }

            Group? group = context.Groups
                .Where(g => g.GroupId == _group.GroupId)
                .FirstOrDefault();

            if (group is null)
            {
                Assert.Fail("Could not find model instance");
                return;
            }

            group.Name = Faker.Company.Name();
            group.Number = Faker.RandomNumber.Next(1, 6);
            context.SaveChanges();

            Group? groupCompare = context.Groups
                .Where(g => g.GroupId == group.GroupId)
                .FirstOrDefault() ?? new Group();

            Assert.That(group.Name, Is.EqualTo(groupCompare?.Name));
        }

        /// <summary>
        /// Tests whether Entity Framework can delete an instance of a modal.
        /// </summary>
        [Test, Order(4), NonParallelizable]
        public void AssessmentContext_CanDelete()
        {
            using var context = new AssessmentContext();

            if (_group is null)
            {
                Assert.Fail("Test model instance is null");
                return;
            }

            Group? group = context.Groups
                .Where(g => g.GroupId == _group.GroupId)
                .FirstOrDefault();

            if (group is null)
            {
                Assert.Fail("Could not find model instance");
                return;
            }

            context.Remove(group);
            context.SaveChanges();

            group = context.Groups
                 .Where(g => g.GroupId == _group.GroupId)
                 .FirstOrDefault();

            Assert.IsNull(group);
        }

        [Test]
        public void AsessmentContext_CanQueryManyToMany()
        {
            // TODO create seeder
            var context = new AssessmentContext();

            var group = context.Groups
                .Include(group => group.Students)
                .Where(g => g.GroupId == _groups[0].GroupId)
                .First();

            Assert.That(group.Students.Count, Is.EqualTo(_groups[0].Students.Count));

            Console.WriteLine($"Group {group.Name} has the following students:");
            foreach (var student in group.Students)
                Console.WriteLine(student.Name);

        }

        [TearDown]
        public void TearDown()
        {
            var context = new AssessmentContext();

            _students.ForEach(s => context.Remove(s));
            _groups.ForEach(g => context.Remove(g));
            context.SaveChanges();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Service.Database;
using Faker;

namespace Service.UnitTest.Database
{
    public class AssessmentContextTest
    {
        /// <summary>
        /// Entity Framework database context.
        /// </summary>
        private AssessmentContext _context;
        /// <summary>
        /// Holds the temporary instance of a model for CRUD testing.
        /// </summary>
        private Group? _group;

        [SetUp]
        public void Setup()
        {
            _context = new AssessmentContext();
        }

        /// <summary>
        /// Tests whether Entity Framework can create an instance of a modal.
        /// </summary>
        [Test, Order(1), NonParallelizable]
        public void AssessmentContext_CanCreate()
        {
            _context.Add(new Group { Name = Faker.Company.Name(), Number = Faker.RandomNumber.Next(1, 6) });
            _context.SaveChanges();

            Group? group = _context.Groups
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
            Group? group = _context.Groups
                .Where(g => g.GroupId == _group.GroupId)
                .FirstOrDefault();

            Assert.IsNotNull(group);
            Assert.That(group.Name, Is.EqualTo(_group?.Name));

            Console.WriteLine(group.Name);
        }

        /// <summary>
        /// Tests whether Entity Framework can update an instance of a modal.
        /// </summary>
        [Test, Order(3), NonParallelizable]

        public void AssessmentContext_CanUpdate()
        {
            Group? group = _context.Groups
                .Where(g => g.GroupId == _group.GroupId)
                .FirstOrDefault();

            if (group is null)
            {
                Assert.Fail("Could not find model instance");
                return;
            }

            group.Name = Faker.Company.Name();
            group.Number = Faker.RandomNumber.Next(1, 6);
            _context.SaveChanges();

            Group? groupCompare = _context.Groups
                .Where(g => g.GroupId == group.GroupId)
                .FirstOrDefault() ?? new Group();

            Assert.That(group.Name, Is.EqualTo(groupCompare?.Name));

            Console.WriteLine(group.Name);
        }

        /// <summary>
        /// Tests whether Entity Framework can delete an instance of a modal.
        /// </summary>
        [Test, Order(4), NonParallelizable]
        public void AssessmentContext_CanDelete()
        {
            Group? group = _context.Groups
                .Where(g => g.GroupId == _group.GroupId)
                .FirstOrDefault();

            if (group is null)
            {
                Assert.Fail("Could not find model instance");
                return;
            }

            _context.Remove(group);
            _context.SaveChanges();

            group = _context.Groups
                 .Where(g => g.GroupId == _group.GroupId)
                 .FirstOrDefault();

            Assert.IsNull(group);
        }

        [TearDown]
        public void TearDown()
        {
            _context.Dispose();
        }
    }
}

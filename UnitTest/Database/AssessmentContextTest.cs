using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using Service.Database;

namespace Service.UnitTest.Database
{
    public class AssessmentContextTest
    {
        private AssessmentContext _context;

        [SetUp]
        public void Setup()
        {
            _context = new AssessmentContext();
        }

        [Test]
        public void Test1()
        {
            _context.Add(new Group { Name = "a", Number = 1 });
            _context.SaveChanges();
        }

        [TearDown]
        public void TearDown()
        {
            _context.Dispose();
        }
    }
}

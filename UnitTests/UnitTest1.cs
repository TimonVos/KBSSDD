using System.Collections.ObjectModel;
using Model;
using System.Diagnostics;
using Service.Database;

namespace UnitTests
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void Projects()
        {
            using var context = new AssessmentContext();

            var projects = from p in context.Projects where p.ProjectId > 0 select p;
        }
    }
}

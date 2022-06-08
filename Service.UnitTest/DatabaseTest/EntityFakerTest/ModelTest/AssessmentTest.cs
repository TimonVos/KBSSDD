using Service.Database;
using Service.Database.EntityFaker;
using Service.Database.EntityFaker.Args;

namespace Service.UnitTest.Database.EntityFakerTest.ModelTest
{
    [TestFixture]
    internal class AssessmentTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void EntityFaker_can_create_an_assessment()
        {
            var assessmentA = EntityFaker.CreateAssessment(new AssessmentArgs { Save = true });
            var assessmentB = EntityFaker.CreateAssessment(new AssessmentArgs { Save = true });

            Assert.That(assessmentA.AssessmentId, Is.Not.EqualTo(assessmentB.AssessmentId));

            EntityFaker.RemoveRange(new[] { assessmentA, assessmentB }, true);
        }

        [Test]
        public void EntityFaker_can_create_assessments()
        {
            var assessmentsA = EntityFaker.CreateAssessments(new AssessmentsArgs { Save = true });
            var assessmentsB = EntityFaker.CreateAssessments(new AssessmentsArgs { Save = true });

            var assessmentsT = assessmentsA.ToList();
            assessmentsT.AddRange(assessmentsB);
            Assert.That(assessmentsT.DistinctBy(p => p.AssessmentId).Count, Is.EqualTo(assessmentsA.Count() + assessmentsB.Count()));

            EntityFaker.RemoveRange(assessmentsT, true);
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}

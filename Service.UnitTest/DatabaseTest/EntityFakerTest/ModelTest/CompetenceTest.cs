using Service.Database;
using Service.Database.EntityFaker;
using Service.Database.EntityFaker.Args;

namespace Service.UnitTest.Database.EntityFakerTest.ModelTest
{
    [TestFixture]
    internal class CompetenceTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void EntityFaker_can_create_a_competence()
        {
            var competenceA = EntityFaker.CreateCompetence(new CompetenceArgs { Save = true });
            var competenceB = EntityFaker.CreateCompetence(new CompetenceArgs { Save = true });

            Assert.That(competenceA.CompetenceId, Is.Not.EqualTo(competenceB.CompetenceId));

            EntityFaker.RemoveRange(new[] { competenceA, competenceB }, true);
        }

        [Test]
        public void EntityFaker_can_create_competences()
        {
            var competencesA = EntityFaker.CreateCompetences(new CompetencesArgs { Save = true });
            var competencesB = EntityFaker.CreateCompetences(new CompetencesArgs { Save = true });

            var competencesT = competencesA.ToList();
            competencesT.AddRange(competencesB);
            Assert.That(competencesT.DistinctBy(c => c.CompetenceId).Count, Is.EqualTo(competencesA.Count() + competencesB.Count()));

            EntityFaker.RemoveRange(competencesT, true);
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}

using Model;
using Service.Database;
using Service.Database.EntityFaker;

namespace Service.UnitTest.DatabaseTest.ModelTest
{
    [TestFixture]
    internal class CompetenceTest
    {
        [SetUp]
        public void Setup()
        {
        }

        #region Assert attributes

        [Test]
        public void Competence_name_is_required()
        {
            using var container = EntityFaker.Contained.CreateCompetence();

            container.Instance.Name = null!;
            DatabaseAssert.Throws(() => container.Save(), 515, nameof(container.Instance.Name));
        }

        [Test]
        public void Competence_description_is_required()
        {
            using var container = EntityFaker.Contained.CreateCompetence();

            container.Instance.Description = null!;
            DatabaseAssert.Throws(() => container.Save(), 515, nameof(container.Instance.Description));
        }

        [Test]
        public void Competence_evidence_is_required()
        {
            using var container = EntityFaker.Contained.CreateCompetence();

            container.Instance.Evidence = null!;
            DatabaseAssert.Throws(() => container.Save(), 515, nameof(container.Instance.Evidence));
        }

        #endregion

        #region Assert CRUD

        [Test]
        public void Competences_can_be_created()
        {
            using var container = EntityFaker.Contained.CreateCompetence().Save();

            using var context = new AssessmentContext();
            Assert.That(context.Competences.Any(
                c => c.CompetenceId == container.Instance.CompetenceId
            ), Is.True);
        }

        [Test]
        public void Competence_can_be_read()
        {
            using var container = EntityFaker.Contained.CreateCompetence().Save();

            using var context = new AssessmentContext();
            Competence? competence = (from c in context.Competences
                            where c.CompetenceId == container.Instance.CompetenceId
                            select c).FirstOrDefault();

            Assert.That(competence, Is.Not.Null);
            Assert.Multiple(() =>
            {
                Assert.That(competence.FormId, Is.EqualTo(container.Instance.FormId));
                Assert.That(competence.CompetenceId, Is.EqualTo(container.Instance.CompetenceId));
                Assert.That(competence.Name, Is.EqualTo(container.Instance.Name));
                Assert.That(competence.Description, Is.EqualTo(container.Instance.Description));
                Assert.That(competence.Weight, Is.EqualTo(container.Instance.Weight));
                Assert.That(competence.Evidence, Is.EqualTo(container.Instance.Evidence));
            });
        }

        [Test]
        public void Competence_can_be_updated()
        {
            using var container = EntityFaker.Contained.CreateCompetence().Save();

            AssessmentContext context;

            context = new AssessmentContext();
            Competence? before = (from c in context.Competences
                             where c.CompetenceId == container.Instance.CompetenceId
                             select c).FirstOrDefault();

            var temp = EntityFaker.CreateCompetence();
            before!.Name = temp.Name;
            before!.Description = temp.Description;
            before!.Weight = temp.Weight;
            before!.Evidence = temp.Evidence;

            context.Competences.Update(before);
            context.SaveChanges();
            context.Dispose();

            context = new AssessmentContext();
            Competence? after = (from c in context.Competences
                            where c.CompetenceId == container.Instance.CompetenceId
                            select c).FirstOrDefault();

            Assert.That(after, Is.Not.Null);
            Assert.Multiple(() =>
            {
                Assert.That(after.CompetenceId, Is.EqualTo(before.CompetenceId));
                Assert.That(after.FormId, Is.EqualTo(before.FormId));
                Assert.That(after.Name, Is.EqualTo(before.Name ));
                Assert.That(after.Description, Is.EqualTo(before.Description ));
                Assert.That(after.Weight, Is.EqualTo(before.Weight ));
                Assert.That(after.Evidence, Is.EqualTo(before.Evidence ));
            });
        }

        [Test]
        public void Competence_can_be_deleted()
        {
            using var container = EntityFaker.Contained.CreateCompetence().Save();

            AssessmentContext context;

            context = new AssessmentContext();
            context.Competences.Remove(container.Instance);
            context.SaveChanges();
            context.Dispose();

            context = new AssessmentContext();
            Assert.That(context.Competences.Any(
                c => c.CompetenceId == container.Instance.CompetenceId
            ), Is.False);
        }

        #endregion

        #region Assert relationships

        [Test]
        public void Competence_can_belong_to_forms()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void Competence_can_have_critera()
        {
            throw new NotImplementedException();
        }

        #endregion

        [TearDown]
        public void TearDown()
        {
        }
    }
}

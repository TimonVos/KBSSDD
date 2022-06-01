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

            container.Instance.Name = null!;
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
            throw new NotImplementedException();
        }

        [Test]
        public void Competence_can_be_read()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void Competence_can_be_updated()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void Competence_can_be_deleted()
        {
            throw new NotImplementedException();
        }

        #endregion

        #region Assert relationships

        [Test]
        public void Competence_can_belong_to_a_forms()
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

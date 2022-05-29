using Bogus;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Model;
using Service.Database;

namespace Service.UnitTest.Database.Model
{
    [TestFixture]
    internal class CompetenceTest
    {
        private Faker _faker = new Faker();
        private Faker<Form> _formFaker;
        private Faker<Competence> _competenceFaker;
        private Faker<Criterion> _criterionFaker;

        [SetUp]
        public void Setup()
        {
            _formFaker = new Faker<Form>()
                .RuleFor(f => f.Name, f => f.Lorem.Sentence())
                .RuleFor(f => f.Description, f => f.Lorem.Paragraph());

            _competenceFaker = new Faker<Competence>()
                .RuleFor(c => c.Name, f => f.Lorem.Sentence())
                .RuleFor(c => c.Description, f => f.Lorem.Paragraph())
                .RuleFor(c => c.Evidence, f => f.Lorem.Paragraph())
                .RuleFor(c => c.Weight, f => f.Random.Float());

            _criterionFaker = new Faker<Criterion>()
                .RuleFor(f => f.Name, f => f.Lorem.Sentence())
                .RuleFor(f => f.Description, f => f.Lorem.Paragraph());
        }

        #region Assert attributes

        [Test]
        public void Competences_id_cannot_be_inserted()
        {
            using var context = new AssessmentContext();

            var competence = _competenceFaker.Generate();
            competence.CompetenceId = 1;

            context.Competences.Add(competence);

            var exception = Assert.Throws<DbUpdateException>(() => context.SaveChanges());
            Assert.That(exception.InnerException, Is.InstanceOf<SqlException>());
            SqlException? sqlException = (SqlException?)(exception.InnerException);
            if (sqlException is not null)
            {
                Assert.That(sqlException.Number, Is.EqualTo(544));
                StringAssert.Contains("IDENTITY_INSERT is set to OFF", sqlException.Message);
            }
        }

        [Test]
        public void Competences_required_fields_are_not_nullable()
        {
            using var context = new AssessmentContext();
            var form = _formFaker.Generate();
            var competence = _competenceFaker.Generate();
            context.Competences.Add(competence);
            context.Forms.Add(form);
            DbUpdateException exception;
            SqlException? sqlException;

            exception = Assert.Throws<DbUpdateException>(() => context.SaveChanges());
            Assert.That(exception.InnerException, Is.InstanceOf<SqlException>());
            sqlException = (SqlException?)(exception.InnerException);
            if (sqlException is not null)
            {
                Assert.That(sqlException.Number, Is.EqualTo(547));
                StringAssert.Contains("FormId", sqlException.Message);
            }
            competence.Form = form;

            competence.Name = null!;
            exception = Assert.Throws<DbUpdateException>(() => context.SaveChanges());
            Assert.That(exception.InnerException, Is.InstanceOf<SqlException>());
            sqlException = (SqlException?)(exception.InnerException);
            if (sqlException is not null)
            {
                Assert.That(sqlException.Number, Is.EqualTo(515));
                StringAssert.Contains("Name", sqlException.Message);
            }
            _competenceFaker.Populate(competence);

            _competenceFaker.Populate(competence);
            competence.Description = null!;
            exception = Assert.Throws<DbUpdateException>(() => context.SaveChanges());
            Assert.That(exception.InnerException, Is.InstanceOf<SqlException>());
            sqlException = (SqlException?)(exception.InnerException);
            if (sqlException is not null)
            {
                Assert.That(sqlException.Number, Is.EqualTo(515));
                StringAssert.Contains("Description", sqlException.Message);
            }

            _competenceFaker.Populate(competence);
            competence.Evidence = null!;
            exception = Assert.Throws<DbUpdateException>(() => context.SaveChanges());
            Assert.That(exception.InnerException, Is.InstanceOf<SqlException>());
            sqlException = (SqlException?)(exception.InnerException);
            if (sqlException is not null)
            {
                Assert.That(sqlException.Number, Is.EqualTo(515));
                StringAssert.Contains("Evidence", sqlException.Message);
            }

            context.Competences.Remove(competence);
            context.Remove(form);
            context.SaveChanges();
        }

        #endregion

        #region Assert CRUD

        [Test]
        public void Competences_can_be_created()
        {
            using var context = new AssessmentContext();
            var form = _formFaker.Generate();
            var competence = _competenceFaker.Generate();
            competence.Form = form;
            context.Competences.Add(competence);
            context.Forms.Add(form);
            context.SaveChanges();

            using var createContext = new AssessmentContext();
            competence = (from c in createContext.Competences
                          where c.CompetenceId == competence.CompetenceId
                          select c).FirstOrDefault();
            Assert.That(competence, Is.Not.Null);

            createContext.Remove(competence!);
            form = (from f in createContext.Forms
                    where f.FormId == form.FormId
                    select f).FirstOrDefault();
            createContext.Remove(form!);
            createContext.SaveChanges();
        }

        [Test]
        public void Competences_can_be_read()
        {
            using var context = new AssessmentContext();
            var form = _formFaker.Generate();
            var competence = _competenceFaker.Generate();
            competence.Form = form;
            context.Competences.Add(competence);
            context.Forms.Add(form);
            context.SaveChanges();

            using var readContext = new AssessmentContext();
            var read = (from c in readContext.Competences
                        where c.CompetenceId == competence.CompetenceId
                        select c).Include(c => c.Form).FirstOrDefault();
            Assert.Multiple(() =>
            {
                Assert.That(read, Is.Not.Null);
                Assert.That(competence.CompetenceId, Is.EqualTo(read?.CompetenceId));
                Assert.That(competence.Name, Is.EqualTo(read?.Name));
                Assert.That(competence.Description, Is.EqualTo(read?.Description));
                Assert.That(competence.Evidence, Is.EqualTo(read?.Evidence));
                Assert.That(competence.Weight, Is.EqualTo(read?.Weight));
                Assert.That(competence.FormId, Is.EqualTo(read?.FormId));
                Assert.That(competence.Form.FormId, Is.EqualTo(read?.Form.FormId));
            });

            readContext.Remove(read!);
            form = (from f in readContext.Forms
                    where f.FormId == form.FormId
                    select f).FirstOrDefault();
            readContext.Remove(form!);
            readContext.SaveChanges();
        }

        [Test]
        public void Competences_can_be_updated()
        {
            using var context = new AssessmentContext();
            var form = _formFaker.Generate();
            var competence = _competenceFaker.Generate();
            competence.Form = form;
            context.Competences.Add(competence);
            context.Forms.Add(form);
            context.SaveChanges();

            using var updateContext = new AssessmentContext();
            var updateForm = _formFaker.Generate();
            var update = (from c in updateContext.Competences
                          where c == competence
                          select c).FirstOrDefault();
            Assert.That(update, Is.Not.Null);
            update.Name = _faker.Lorem.Sentence();
            update.Description = _faker.Lorem.Paragraph();
            update.Evidence = _faker.Lorem.Paragraph();
            update.Weight = _faker.Random.Float();
            update.Form = updateForm;
            updateContext.Forms.Add(updateForm);
            updateContext.SaveChanges();

            using var readContext = new AssessmentContext();
            var read = (from c in readContext.Competences
                        where c == competence
                        select c).Include(c => c.Form).FirstOrDefault();
            Assert.Multiple(() =>
            {
                Assert.That(read, Is.Not.Null);
                Assert.That(read?.CompetenceId, Is.EqualTo(update.CompetenceId));
                Assert.That(read?.Name, Is.EqualTo(update.Name));
                Assert.That(read?.Description, Is.EqualTo(update.Description));
                Assert.That(read?.Evidence, Is.EqualTo(update.Evidence));
                Assert.That(read?.Weight, Is.EqualTo(update.Weight));
                Assert.That(read?.FormId, Is.EqualTo(update.FormId));
                Assert.That(read?.Form.FormId, Is.EqualTo(update.Form.FormId));
            });

            readContext.Remove(read!);
            readContext.Remove(form);
            form = (from f in readContext.Forms
                    where f == form
                    select f).FirstOrDefault();
            readContext.Remove(form!);
            updateForm = (from f in readContext.Forms
                          where f == updateForm
                          select f).FirstOrDefault();
            readContext.Remove(updateForm!);
            readContext.SaveChanges();
        }

        [Test]
        public void Competences_can_be_deleted()
        {
            using var context = new AssessmentContext();
            var form = _formFaker.Generate();
            var competence = _competenceFaker.Generate();
            competence.Form = form;
            context.Competences.Add(competence);
            context.Forms.Add(form);
            context.SaveChanges();

            using var deleteContext = new AssessmentContext();
            deleteContext.Remove(competence);
            deleteContext.SaveChanges();
            competence = (from c in deleteContext.Competences
                          where c == competence
                          select c).FirstOrDefault();
            Assert.That(competence, Is.Null);

            form = (from f in deleteContext.Forms
                    where f == form
                    select f).FirstOrDefault();
            deleteContext.Remove(form!);
            deleteContext.SaveChanges();
        }

        #endregion

        #region Assert relationships

        [Test]
        public void Competences_can_belong_to_forms()
        {
            using var context = new AssessmentContext();
            var competencesA = _competenceFaker.Generate(2);
            var formA = _formFaker.Generate();
            competencesA.ForEach(c => c.Form = formA);
            context.Forms.Add(formA);
            context.Competences.AddRange(competencesA);
            context.SaveChanges();

            using var formsContext = new AssessmentContext();
            var competencesB = (from c in formsContext.Competences
                                where c.Form == formA
                                select c).Include(c => c.Form).ToList();
            Assert.Multiple(() =>
            {
                Assert.That(competencesB.Count, Is.EqualTo(competencesA.Count));
                competencesB.ForEach(c => Assert.That(c.Form.FormId, Is.EqualTo(formA.FormId)));
            });

            context.RemoveRange(competencesA);
            context.Remove(formA);
            context.SaveChanges();
        }

        [Test]
        public void Competences_can_have_critera()
        {
            using var context = new AssessmentContext();
            var formA = _formFaker.Generate();
            var competenceA = _competenceFaker.Generate();
            competenceA.Form = formA;
            var criteriaA = _criterionFaker.Generate(2);
            criteriaA.ForEach(c => c.Competence = competenceA);
            context.Forms.Add(formA);
            context.Competences.Add(competenceA);
            context.Criteria.AddRange(criteriaA);
            context.SaveChanges();

            using var criteriaContext = new AssessmentContext();
            var competenceB = (from c in criteriaContext.Competences
                               where c == competenceA
                               select c).Include(c => c.Criteria).FirstOrDefault();
            Assert.Multiple(() =>
            {
                Assert.That(competenceB, Is.Not.Null);
                Assert.That(competenceB?.Criteria.Count, Is.EqualTo(criteriaA.Count));
                Assert.That((from a in criteriaA
                             join b in competenceB!.Criteria on a.CriterionId equals b.CriterionId
                             select a).Count, Is.EqualTo(criteriaA.Count));
            });

            context.Remove(formA);
            context.SaveChanges();
        }

        #endregion

        [TearDown]
        public void TearDown()
        {

        }
    }
}

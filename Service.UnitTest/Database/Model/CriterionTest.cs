using Bogus;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Model;
using Service.Database;

namespace Service.UnitTest.Database.Model
{
    [TestFixture]
    internal class CriterionTest
    {
        private Faker _faker = new Faker();
        private Faker<Form> _formFaker;
        private Faker<Competence> _competenceFaker;
        private Faker<Criterion> _criterionFaker;
        private Faker<Requirement> _requirementFaker;
        private Faker<Indicator> _indicatorFaker;

        [SetUp]
        public void Setup()
        {
            _formFaker = new Faker<Form>()
                .RuleFor(f => f.Name, f => f.Lorem.Sentence())
                .RuleFor(f => f.Description, f => f.Lorem.Paragraph());

            _competenceFaker = new Faker<Competence>()
                .RuleFor(f => f.Name, f => f.Lorem.Sentence())
                .RuleFor(f => f.Description, f => f.Lorem.Paragraph())
                .RuleFor(f => f.Evidence, f => f.Lorem.Paragraph())
                .RuleFor(f => f.Weight, f => f.Random.Float());

            _criterionFaker = new Faker<Criterion>()
                .RuleFor(f => f.Name, f => f.Lorem.Sentence())
                .RuleFor(f => f.Description, f => f.Lorem.Paragraph());

            _requirementFaker = new Faker<Requirement>()
                .RuleFor(f => f.Name, f => f.Lorem.Sentence())
                .RuleFor(f => f.Description, f => f.Lorem.Paragraph());

            _indicatorFaker = new Faker<Indicator>()
                .RuleFor(f => f.Name, f => f.Lorem.Random.Word())
                .RuleFor(f => f.Value, f => f.Lorem.Random.Number(1, 10));
        }

        #region Assert attributes

        [Test]
        public void Criteria_id_cannot_be_inserted()
        {
            using var context = new AssessmentContext();

            var criterion = _criterionFaker.Generate();
            criterion.CriterionId = 1;

            context.Criteria.Add(criterion);

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
        public void Criteria_required_fields_are_not_nullable()
        {
            using var context = new AssessmentContext();
            var form = _formFaker.Generate();
            var competence = _competenceFaker.Generate();
            competence.Form = form;
            var criterion = _criterionFaker.Generate();
            context.Criteria.Add(criterion);
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
                StringAssert.Contains("CompetenceId", sqlException.Message);
            }
            criterion.Competence = competence;

            criterion.Name = null!;
            exception = Assert.Throws<DbUpdateException>(() => context.SaveChanges());
            Assert.That(exception.InnerException, Is.InstanceOf<SqlException>());
            sqlException = (SqlException?)(exception.InnerException);
            if (sqlException is not null)
            {
                Assert.That(sqlException.Number, Is.EqualTo(515));
                StringAssert.Contains("Name", sqlException.Message);
            }
            _criterionFaker.Populate(criterion);

            _criterionFaker.Populate(criterion);
            criterion.Description = null!;
            exception = Assert.Throws<DbUpdateException>(() => context.SaveChanges());
            Assert.That(exception.InnerException, Is.InstanceOf<SqlException>());
            sqlException = (SqlException?)(exception.InnerException);
            if (sqlException is not null)
            {
                Assert.That(sqlException.Number, Is.EqualTo(515));
                StringAssert.Contains("Description", sqlException.Message);
            }

            context.Criteria.Remove(criterion);
            context.Remove(form);
            context.SaveChanges();
        }

        #endregion

        #region Assert CRUD

        [Test]
        public void Criteria_can_be_created()
        {
            using var context = new AssessmentContext();
            var form = _formFaker.Generate();
            var competence = _competenceFaker.Generate();
            competence.Form = form;
            var criterion = _criterionFaker.Generate();
            criterion.Competence = competence;
            context.Criteria.Add(criterion);
            context.Competences.Add(competence);
            context.Forms.Add(form);
            context.SaveChanges();

            using var createContext = new AssessmentContext();
            criterion = (from i in createContext.Criteria
                          where i == criterion
                          select i).FirstOrDefault();
            Assert.That(criterion, Is.Not.Null);

            form = (from f in createContext.Forms
                    where f == form
                    select f).FirstOrDefault();
            createContext.Remove(form!);
            createContext.SaveChanges();
        }

        [Test]
        public void Criteria_can_be_read()
        {
            using var context = new AssessmentContext();
            var form = _formFaker.Generate();
            var competence = _competenceFaker.Generate();
            competence.Form = form;
            var criterion = _criterionFaker.Generate();
            criterion.Competence = competence;
            context.Criteria.Add(criterion);
            context.Competences.Add(competence);
            context.Forms.Add(form);
            context.SaveChanges();

            using var readContext = new AssessmentContext();
            var read = (from c in readContext.Criteria
                        where c.CriterionId == criterion.CriterionId
                        select c).Include(c => c.Competence).FirstOrDefault();
            Assert.Multiple(() =>
            {
                Assert.That(read, Is.Not.Null);
                Assert.That(criterion.CriterionId, Is.EqualTo(read?.CriterionId));
                Assert.That(criterion.Name, Is.EqualTo(read?.Name));
                Assert.That(criterion.Description, Is.EqualTo(read?.Description));
                Assert.That(criterion.CompetenceId, Is.EqualTo(read?.CompetenceId));
                Assert.That(criterion.Competence.CompetenceId, Is.EqualTo(read?.Competence.CompetenceId));
            });

            form = (from f in readContext.Forms
                    where f == form
                    select f).FirstOrDefault();
            readContext.Remove(form!);
            readContext.SaveChanges();
        }

        [Test]
        public void Criteria_can_be_updated()
        {
            using var context = new AssessmentContext();
            var form = _formFaker.Generate();
            var competence = _competenceFaker.Generate();
            competence.Form = form;
            var criterion = _criterionFaker.Generate();
            criterion.Competence = competence;
            context.Criteria.Add(criterion);
            context.Competences.Add(competence);
            context.Forms.Add(form);
            context.SaveChanges();

            using var updateContext = new AssessmentContext();
            var updateCompetence = _competenceFaker.Generate();
            form = (from f in updateContext.Forms
                          where f == form
                          select f).FirstOrDefault();
            updateCompetence.Form = form!;
            var update = (from c in updateContext.Criteria
                          where c == criterion
                          select c).FirstOrDefault();
            Assert.That(update, Is.Not.Null);
            update.Name = _faker.Lorem.Sentence();
            update.Description = _faker.Lorem.Paragraph();
            update.Competence = updateCompetence;
            updateContext.Competences.Add(updateCompetence);
            updateContext.SaveChanges();

            using var readContext = new AssessmentContext();
            var read = (from c in readContext.Criteria
                        where c.CriterionId == criterion.CriterionId
                        select c).Include(c => c.Competence).FirstOrDefault();
            Assert.Multiple(() =>
            {
                Assert.That(read, Is.Not.Null);
                Assert.That(read?.CriterionId, Is.EqualTo(update.CriterionId));
                Assert.That(read?.Name, Is.EqualTo(update.Name));
                Assert.That(read?.Description, Is.EqualTo(update.Description));
                Assert.That(read?.CompetenceId, Is.EqualTo(update.CompetenceId));
                Assert.That(read?.Competence.CompetenceId, Is.EqualTo(update.Competence.CompetenceId));
            });

            form = (from f in readContext.Forms
                    where f == form
                    select f).FirstOrDefault();
            readContext.Remove(form!);
            readContext.SaveChanges();
        }

        [Test]
        public void Criteria_can_be_deleted()
        {
            using var context = new AssessmentContext();
            var form = _formFaker.Generate();
            var competence = _competenceFaker.Generate();
            competence.Form = form;
            var criterion = _criterionFaker.Generate();
            criterion.Competence = competence;
            context.Criteria.Add(criterion);
            context.Competences.Add(competence);
            context.Forms.Add(form);
            context.SaveChanges();

            using var deleteContext = new AssessmentContext();
            deleteContext.Remove(criterion);
            deleteContext.SaveChanges();
            criterion = (from i in deleteContext.Criteria
                          where i == criterion
                          select i).FirstOrDefault();
            Assert.That(criterion, Is.Null);

            form = (from f in deleteContext.Forms
                    where f.FormId == form.FormId
                    select f).FirstOrDefault();
            deleteContext.Remove(form!);
            deleteContext.SaveChanges();
        }

        #endregion

        #region Assert relationships

        [Test]
        public void Criteria_can_have_requirements()
        {
            using var context = new AssessmentContext();
            var formA = _formFaker.Generate();
            var competenceA = _competenceFaker.Generate();
            competenceA.Form = formA;
            var criterionA = _criterionFaker.Generate();
            criterionA.Competence = competenceA;
            var indicatorA = _indicatorFaker.Generate();
            var requirementsA = _requirementFaker.Generate(2);
            requirementsA.ForEach(r => criterionA.Requirements.Add(r));
            requirementsA.ForEach(r => r.Indicator = indicatorA);
            context.Indicators.Add(indicatorA);
            context.Forms.Add(formA);
            context.Competences.Add(competenceA);
            context.Criteria.Add(criterionA);
            context.Requirements.AddRange(requirementsA);
            context.SaveChanges();

            using var requirementsContext = new AssessmentContext();
            var critierionB = (from r in requirementsContext.Criteria
                               where r == criterionA
                               select r).Include(c => c.Requirements).FirstOrDefault();
            Assert.Multiple(() =>
            {
                Assert.That(critierionB, Is.Not.Null);
                Assert.That(critierionB?.Requirements.Count, Is.EqualTo(requirementsA.Count));
                Assert.That((from a in requirementsA
                             join b in critierionB!.Requirements on a.RequirementId equals b.RequirementId
                             select a).Count, Is.EqualTo(requirementsA.Count));
            });

            context.Remove(indicatorA);
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

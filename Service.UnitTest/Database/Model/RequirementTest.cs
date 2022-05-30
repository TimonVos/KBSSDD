using Bogus;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Model;
using Service.Database;

namespace Service.UnitTest.Database.Model
{
    [TestFixture]
    internal class RequirementTest
    {
        private Faker _faker = new Faker();
        private Faker<Indicator> _indicatorFaker;
        private Faker<Form> _formFaker;
        private Faker<Competence> _competenceFaker;
        private Faker<Criterion> _criterionFaker;
        private Faker<Requirement> _requirementFaker;

        [SetUp]
        public void Setup()
        {
            _indicatorFaker = new Faker<Indicator>()
                .RuleFor(f => f.Name, f => f.Lorem.Sentence())
                .RuleFor(f => f.Value, f => f.Random.Number(1, 10));

            _formFaker = new Faker<Form>()
                .RuleFor(f => f.Name, f => f.Lorem.Sentence());

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
        }

        #region Assert attributes

        [Test]
        public void Requirements_id_cannot_be_inserted()
        {
            using var context = new AssessmentContext();

            var requirement = _requirementFaker.Generate();
            requirement.RequirementId = 1;

            context.Requirements.Add(requirement);

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
        public void Requirements_required_fields_are_not_nullable()
        {
            using var context = new AssessmentContext();
            var indicator = _indicatorFaker.Generate();
            var form = _formFaker.Generate();
            var competence = _competenceFaker.Generate();
            competence.Form = form;
            var criterion = _criterionFaker.Generate();
            criterion.Competence = competence;
            var requirement = _requirementFaker.Generate();
            context.Criteria.Add(criterion);
            context.Competences.Add(competence);
            context.Forms.Add(form);
            context.Indicators.Add(indicator);
            context.Requirements.Add(requirement);
            DbUpdateException exception;
            SqlException? sqlException;

            exception = Assert.Throws<DbUpdateException>(() => context.SaveChanges());
            Assert.That(exception.InnerException, Is.InstanceOf<SqlException>());
            sqlException = (SqlException?)(exception.InnerException);
            if (sqlException is not null)
            {
                Assert.That(sqlException.Number, Is.EqualTo(547));
                StringAssert.Contains("CriterionId", sqlException.Message);
            }
            requirement.Criterion = criterion;

            exception = Assert.Throws<DbUpdateException>(() => context.SaveChanges());
            Assert.That(exception.InnerException, Is.InstanceOf<SqlException>());
            sqlException = (SqlException?)(exception.InnerException);
            if (sqlException is not null)
            {
                Assert.That(sqlException.Number, Is.EqualTo(547));
                StringAssert.Contains("IndicatorId", sqlException.Message);
            }
            requirement.Indicator = indicator;

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
            context.Remove(indicator);
            context.SaveChanges();
        }

        #endregion

        #region Assert CRUD

        [Test]
        public void Requirements_can_be_created()
        {
            using var context = new AssessmentContext();
            var indicator = _indicatorFaker.Generate();
            var form = _formFaker.Generate();
            var competence = _competenceFaker.Generate();
            competence.Form = form;
            var criterion = _criterionFaker.Generate();
            criterion.Competence = competence;
            var requirement = _requirementFaker.Generate();
            requirement.Indicator = indicator;
            requirement.Criterion = criterion;
            context.Criteria.Add(criterion);
            context.Competences.Add(competence);
            context.Forms.Add(form);
            context.Indicators.Add(indicator);
            context.Requirements.Add(requirement);
            context.SaveChanges();

            using var createContext = new AssessmentContext();
            requirement = (from r in createContext.Requirements
                           where r == requirement
                           select r).FirstOrDefault();
            Assert.That(requirement, Is.Not.Null);

            context.Remove(indicator);
            context.SaveChanges();
            form = (from f in createContext.Forms
                    where f == form
                    select f).FirstOrDefault();
            createContext.Remove(form!);
            createContext.SaveChanges();
        }

        [Test]
        public void Requirements_can_be_read()
        {
            using var context = new AssessmentContext();
            var indicator = _indicatorFaker.Generate();
            var form = _formFaker.Generate();
            var competence = _competenceFaker.Generate();
            competence.Form = form;
            var criterion = _criterionFaker.Generate();
            criterion.Competence = competence;
            var requirement = _requirementFaker.Generate();
            requirement.Indicator = indicator;
            requirement.Criterion = criterion;
            context.Criteria.Add(criterion);
            context.Competences.Add(competence);
            context.Forms.Add(form);
            context.Indicators.Add(indicator);
            context.Requirements.Add(requirement);
            context.SaveChanges();

            using var readContext = new AssessmentContext();
            var read = (from r in readContext.Requirements
                        where r == requirement
                        select r).Include(r => r.Indicator).Include(r => r.Criterion).FirstOrDefault();
            Assert.Multiple(() =>
            {
                Assert.That(read, Is.Not.Null);
                Assert.That(requirement.RequirementId, Is.EqualTo(read?.RequirementId));
                Assert.That(requirement.Name, Is.EqualTo(read?.Name));
                Assert.That(requirement.Description, Is.EqualTo(read?.Description));
                Assert.That(requirement.IndicatorId, Is.EqualTo(read?.IndicatorId));
                Assert.That(requirement.Indicator.IndicatorId, Is.EqualTo(read?.Indicator.IndicatorId));
                Assert.That(requirement.CriterionId, Is.EqualTo(read?.CriterionId));
                Assert.That(requirement.Criterion.CriterionId, Is.EqualTo(read?.Criterion.CriterionId));
            });

            context.Remove(indicator);
            context.SaveChanges();
            form = (from f in readContext.Forms
                    where f == form
                    select f).FirstOrDefault();
            readContext.Remove(form!);
            readContext.SaveChanges();
        }

        [Test]
        public void Requirements_can_be_updated()
        {
            using var context = new AssessmentContext();
            var indicator = _indicatorFaker.Generate();
            var form = _formFaker.Generate();
            var competence = _competenceFaker.Generate();
            competence.Form = form;
            var criterion = _criterionFaker.Generate();
            criterion.Competence = competence;
            var requirement = _requirementFaker.Generate();
            requirement.Indicator = indicator;
            requirement.Criterion = criterion;
            context.Criteria.Add(criterion);
            context.Competences.Add(competence);
            context.Forms.Add(form);
            context.Indicators.Add(indicator);
            context.Requirements.Add(requirement);
            context.SaveChanges();

            using var updateContext = new AssessmentContext();
            var updateCriterion = _criterionFaker.Generate();
            competence = (from c in updateContext.Competences
                          where c == competence
                          select c).FirstOrDefault();
            updateCriterion.Competence = competence!;
            var updateIndicator = _indicatorFaker.Generate();
            var update = (from r in updateContext.Requirements
                          where r == requirement
                          select r).FirstOrDefault();
            Assert.That(update, Is.Not.Null);
            update.Name = _faker.Lorem.Sentence();
            update.Description = _faker.Lorem.Paragraph();
            update.Indicator = updateIndicator;
            update.Criterion = updateCriterion;
            updateContext.Indicators.Add(updateIndicator);
            updateContext.Criteria.Add(updateCriterion);
            updateContext.SaveChanges();

            using var readContext = new AssessmentContext();
            var read = (from r in readContext.Requirements
                        where r == requirement
                        select r).Include(r => r.Indicator).Include(r => r.Criterion).FirstOrDefault();
            Assert.Multiple(() =>
            {
                Assert.That(read, Is.Not.Null);
                Assert.That(read?.RequirementId, Is.EqualTo(update?.RequirementId));
                Assert.That(read?.Name, Is.EqualTo(update?.Name));
                Assert.That(read?.Description, Is.EqualTo(update?.Description));
                Assert.That(read?.IndicatorId, Is.EqualTo(update?.IndicatorId));
                Assert.That(read?.Indicator.IndicatorId, Is.EqualTo(update?.Indicator.IndicatorId));
                Assert.That(read?.CriterionId, Is.EqualTo(update?.CriterionId));
                Assert.That(read?.Criterion.CriterionId, Is.EqualTo(update?.Criterion.CriterionId));
            });

            updateContext.Remove(updateIndicator);
            updateContext.SaveChanges();
            form = (from f in readContext.Forms
                    where f == form
                    select f).FirstOrDefault();
            indicator = (from i in readContext.Indicators
                         where i == indicator
                         select i).FirstOrDefault();
            readContext.Remove(indicator!);
            readContext.Remove(form!);
            readContext.SaveChanges();
        }

        [Test]
        public void Requirements_can_be_deleted()
        {
            using var context = new AssessmentContext();
            var indicator = _indicatorFaker.Generate();
            var form = _formFaker.Generate();
            var competence = _competenceFaker.Generate();
            competence.Form = form;
            var criterion = _criterionFaker.Generate();
            criterion.Competence = competence;
            var requirement = _requirementFaker.Generate();
            requirement.Indicator = indicator;
            requirement.Criterion = criterion;
            context.Criteria.Add(criterion);
            context.Competences.Add(competence);
            context.Forms.Add(form);
            context.Indicators.Add(indicator);
            context.Requirements.Add(requirement);
            context.SaveChanges();

            using var deleteContext = new AssessmentContext();
            deleteContext.Remove(requirement);
            deleteContext.SaveChanges();
            requirement = (from r in deleteContext.Requirements
                           where r == requirement
                           select r).FirstOrDefault();
            Assert.That(requirement, Is.Null);

            form = (from f in deleteContext.Forms
                    where f == form
                    select f).FirstOrDefault();
            indicator = (from i in deleteContext.Indicators
                         where i == indicator
                         select i).FirstOrDefault();
            deleteContext.Remove(indicator!);
            deleteContext.Remove(form!);
            deleteContext.SaveChanges();
        }

        #endregion

        #region Assert relationships

        #endregion

        [TearDown]
        public void TearDown()
        {

        }
    }
}

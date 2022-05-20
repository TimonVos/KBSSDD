using Bogus;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Model;
using Service.Database;

namespace Service.UnitTest.Database.Model
{
    [TestFixture]
    internal class IndicatorTest
    {
        private Faker _faker = new Faker();
        private Faker<Indicator> _indicatorFaker;
        private Faker<Form> _formFaker;

        [SetUp]
        public void Setup()
        {
            _indicatorFaker = new Faker<Indicator>()
                .RuleFor(f => f.Name, f => f.Lorem.Random.Word())
                .RuleFor(f => f.Value, f => f.Lorem.Random.Number(1, 10));

            _formFaker = new Faker<Form>()
                .RuleFor(f => f.Description, f => f.Lorem.Paragraph());
        }

        #region Assert attributes

        [Test]
        public void Indicators_id_cannot_be_inserted()
        {
            using var context = new AssessmentContext();

            var indicator = _indicatorFaker.Generate();
            indicator.IndicatorId = 1;

            context.Indicators.Add(indicator);

            var exception = Assert.Throws<DbUpdateException>(() => context.SaveChanges());
            Assert.IsInstanceOf<SqlException>(exception.InnerException);
            SqlException? sqlException = (SqlException?)(exception.InnerException);
            if (sqlException is not null)
                Assert.That(sqlException.Number, Is.EqualTo(544));
        }

        [Test]
        public void Indicators_name_is_required()
        {
            using var context = new AssessmentContext();

            var indicator = new Indicator { Value = 3 };

            context.Indicators.Add(indicator);

            var exception = Assert.Throws<DbUpdateException>(() => context.SaveChanges());
            Assert.IsInstanceOf<SqlException>(exception.InnerException);
            SqlException? sqlException = (SqlException?)(exception.InnerException);
            if (sqlException is not null)
                Assert.That(sqlException.Number, Is.EqualTo(515));
        }

        [Test]
        public void Indicators_name_is_unique()
        {
            using var context = new AssessmentContext();

            var name = _faker.Random.Word();

            var original = new Indicator { Name = name };
            var copy = new Indicator { Name = name };

            context.Indicators.Add(original);
            context.Indicators.Add(copy);

            var exception = Assert.Throws<DbUpdateException>(() => context.SaveChanges());
            Assert.IsInstanceOf<SqlException>(exception.InnerException);
            SqlException? sqlException = (SqlException?)(exception.InnerException);
            if (sqlException is not null)
                Assert.That(sqlException.Number, Is.EqualTo(2601));
        }

        #endregion

        #region Assert CRUD

        [Test]
        public void Indicators_can_be_created()
        {
            using var context = new AssessmentContext();
            var indicator = _indicatorFaker.Generate();
            context.Indicators.Add(indicator);
            context.SaveChanges();

            using var createContext = new AssessmentContext();
            indicator = (from i in createContext.Indicators
                         where i.IndicatorId == indicator.IndicatorId
                         select i).FirstOrDefault();
            Assert.That(indicator, Is.Not.Null);
            createContext.Remove(indicator!);
            createContext.SaveChanges();
        }

        [Test]
        public void Indicators_can_be_read()
        {
            using var context = new AssessmentContext();
            var indicator = _indicatorFaker.Generate();
            context.Indicators.Add(indicator);
            context.SaveChanges();

            using var readContext = new AssessmentContext();
            var read = (from i in readContext.Indicators
                        where i.IndicatorId == indicator.IndicatorId
                        select i).FirstOrDefault();
            Assert.Multiple(() =>
            {
                Assert.That(read, Is.Not.Null);
                Assert.That(indicator.IndicatorId, Is.EqualTo(read?.IndicatorId));
                Assert.That(indicator.Name, Is.EqualTo(read?.Name));
                Assert.That(indicator.Value, Is.EqualTo(read?.Value));
            });
            readContext.Remove(read!);
            readContext.SaveChanges();
        }

        [Test]
        public void Indicators_can_be_updated()
        {
            using var context = new AssessmentContext();
            var indicator = _indicatorFaker.Generate();
            context.Indicators.Add(indicator);
            context.SaveChanges();

            using var updateContext = new AssessmentContext();
            var update = (from i in updateContext.Indicators
                          where i.IndicatorId == indicator.IndicatorId
                          select i).FirstOrDefault();
            Assert.IsNotNull(update);
            update.Name = _faker.Random.Word();
            update.Value = _faker.Random.Number(1, 10);
            updateContext.SaveChanges();

            using var readContext = new AssessmentContext();
            var read = (from i in readContext.Indicators
                        where i.IndicatorId == indicator.IndicatorId
                        select i).FirstOrDefault();
            Assert.Multiple(() =>
            {
                Assert.That(read, Is.Not.Null);
                Assert.That(read?.IndicatorId, Is.EqualTo(update.IndicatorId));
                Assert.That(read?.Name, Is.EqualTo(update.Name));
                Assert.That(read?.Value, Is.EqualTo(update.Value));
            });
            readContext.Remove(read!);
            readContext.SaveChanges();
        }

        [Test]
        public void Indicators_can_be_deleted()
        {
            using var context = new AssessmentContext();
            var indicator = _indicatorFaker.Generate();
            context.Indicators.Add(indicator);
            context.SaveChanges();

            using var deleteContext = new AssessmentContext();
            deleteContext.Remove(indicator);
            deleteContext.SaveChanges();
            indicator = (from i in deleteContext.Indicators
                         where i.IndicatorId == indicator.IndicatorId
                         select i).FirstOrDefault();
            Assert.That(indicator, Is.Null);
        }

        #endregion

        #region Assert relationships

        [Test]
        public void Indicators_can_belong_to_forms()
        {
            using var context = new AssessmentContext();
            var indicatorsA = _indicatorFaker.Generate(2);
            var formA = _formFaker.Generate();
            indicatorsA.ForEach(i => i.Forms.Add(formA));
            context.Indicators.AddRange(indicatorsA);
            context.Forms.Add(formA);
            context.SaveChanges();

            using var formsContext = new AssessmentContext();
            var indicatorsB = (from i in formsContext.Indicators 
                               join fi in formsContext.FormIndicators on i equals fi.Indicator
                               where fi.FormId == formA.FormId 
                               select i).Include(i => i.Forms).ToList();
            Assert.Multiple(() =>
            {
                Assert.That(indicatorsB.Count, Is.EqualTo(indicatorsA.Count));
                indicatorsB.ForEach(i => Assert.That(i.Forms.First().FormId, Is.EqualTo(formA.FormId)));
            });

            context.RemoveRange(indicatorsA);
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

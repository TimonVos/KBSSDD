using Microsoft.EntityFrameworkCore;
using Model;
using Service.Database;
using Service.Database.EntityFaker;

namespace Service.UnitTest.DatabaseTest.ModelTest
{
    [TestFixture]
    internal class IndicatorTest
    {
        [SetUp]
        public void Setup()
        {
        }

        #region Attributes

        [Test]
        public void Indicators_name_is_required()
        {
            using var container = EntityFaker.Contained.CreateIndicator();

            container.Instance.Name = null!;
            DatabaseAssert.Throws(() => container.Save(), 515, nameof(container.Instance.Name));
        }

        [Test]
        public void Indicators_name_is_unique()
        {
            using var unique = EntityFaker.Contained.CreateIndicator().Save();
            using var indicator = EntityFaker.Contained.CreateIndicator();

            indicator.Instance.Name = unique.Instance.Name;

            DatabaseAssert.Throws(() => indicator.Save(), 2601, "Cannot insert duplicate key");
        }

        #endregion

        #region CRUD

        [Test]
        public void Indicators_can_be_created()
        {
            using var container = EntityFaker.Contained.CreateIndicator().Save();

            using var context = new AssessmentContext();
            Assert.That(context.Indicators.Any(
                s => s.IndicatorId == container.Instance.IndicatorId
            ), Is.True);
        }

        [Test]
        public void Indicators_can_be_read()
        {
            using var container = EntityFaker.Contained.CreateIndicator().Save();

            using var context = new AssessmentContext();
            Indicator? indicator = (from i in context.Indicators
                                where i.IndicatorId == container.Instance.IndicatorId
                                select i).FirstOrDefault();

            Assert.That(indicator, Is.Not.Null);
            Assert.Multiple(() =>
            {
                Assert.That(indicator.IndicatorId, Is.EqualTo(container.Instance.IndicatorId));
                Assert.That(indicator.Name, Is.EqualTo(container.Instance.Name));
                Assert.That(indicator.Value, Is.EqualTo(container.Instance.Value));
            });
        }

        [Test]
        public void Indicators_can_be_updated()
        {
            using var container = EntityFaker.Contained.CreateIndicator().Save();

            AssessmentContext context;

            context = new AssessmentContext();
            Indicator? before = (from i in context.Indicators
                             where i.IndicatorId == container.Instance.IndicatorId
                             select i).FirstOrDefault();

            var temp = EntityFaker.CreateIndicator();
            before!.Name = temp.Name;
            before!.Value = temp.Value;

            context.Indicators.Update(before);
            context.SaveChanges();
            context.Dispose();

            context = new AssessmentContext();
            Indicator? after = (from i in context.Indicators
                            where i.IndicatorId == container.Instance.IndicatorId
                            select i).FirstOrDefault();

            Assert.That(after, Is.Not.Null);
            Assert.Multiple(() =>
            {
                Assert.That(after.IndicatorId, Is.EqualTo(before.IndicatorId));
                Assert.That(after.Name, Is.EqualTo(before.Name));
                Assert.That(after.Value, Is.EqualTo(before.Value));
            });
        }

        [Test]
        public void Indicators_can_be_deleted()
        {
            var container = EntityFaker.Contained.CreateIndicator().Save();

            AssessmentContext context;

            context = new AssessmentContext();
            context.Indicators.Remove(container.Instance);
            context.SaveChanges();
            context.Dispose();

            context = new AssessmentContext();
            Assert.That(context.Indicators.Any(
                i => i.IndicatorId == container.Instance.IndicatorId
            ), Is.False);
        }

        #endregion

        #region Relationships

        [Test]
        public void Indicators_can_belong_to_forms()
        {
            throw new NotImplementedException();
        }

        [Test]
        public void Indicators_can_belong_to_requirements()
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

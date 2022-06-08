using Service.Database;
using Service.Database.EntityFaker;

namespace Service.UnitTest.Database.EntityFakerTest.ScenarioTest
{
    [TestFixture]
    internal class FormsWithIndicatorsTest
    {
        [SetUp]
        public void Setup()
        {

        }

        [Test]
        public void EntityFaker_can_create_a_forms_with_indicators_scenario()
        {
            using var scenario = EntityFaker.CreateScenario_FormsWithIndicators(new FormsWithIndicatorsArgs()).Save();

            AssertScenario(scenario);
        }

        [Test]
        public void EntityFaker_can_create_a_form_with_indicators_scenario_with_empty_forms()
        {
            using var scenario = EntityFaker.CreateScenario_FormsWithIndicators(new FormsWithIndicatorsArgs
            {
                formsArgs = new EnumerableFakerArgs { Count = 10 },
                indicatorsArgs = new EnumerableFakerArgs { Count = 1 },
                AllowFormsWithoutIndicators = true,
                MaxIndicatorsPerForm = 1,
            }).Save();

            using var context = new AssessmentContext();

            Assert.That(context.Forms.Any(f => f.Indicators.Count == 0), Is.True);
            AssertScenario(scenario, context);
        }

        [Test]
        public void EntityFaker_can_create_a_form_with_indicators_scenario_without_empty_forms()
        {
            using var scenario = EntityFaker.CreateScenario_FormsWithIndicators(new FormsWithIndicatorsArgs
            {
                formsArgs = new EnumerableFakerArgs { Count = 10 },
                indicatorsArgs = new EnumerableFakerArgs { Count = 1 },
                AllowFormsWithoutIndicators = false,
                MaxIndicatorsPerForm = 1,
            }).Save();

            var context = new AssessmentContext();

            Assert.That(context.Forms.Any(f => f.Indicators.Count == 0), Is.False);
            AssertScenario(scenario, context);
        }

        private void AssertScenario(FormsWithIndicatorsScenario scenario, AssessmentContext? context = null)
        {
            context ??= new AssessmentContext();

            scenario.Forms.ToList().ForEach(f =>
                Assert.That(context.Forms.ToList().Exists(
                    cf => cf.FormId == f.FormId),
                    Is.True
                ));

            scenario.Indicators.ToList().ForEach(i =>
                Assert.That(context.Indicators.ToList().Exists(
                    ci => ci.IndicatorId == i.IndicatorId),
                    Is.True
                ));

            scenario.FormIndicators.ToList().ForEach(fi =>
                Assert.That(context.FormIndicators.ToList().Exists(
                    cfi => cfi.IndicatorId == fi.IndicatorId && cfi.FormId == fi.FormId),
                    Is.True
                ));
        }

        [TearDown]
        public void TearDown()
        {

        }
    }
}

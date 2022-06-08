using Model;

namespace Service.Database.EntityFaker
{
    public static partial class EntityFaker
    {
        public static FormsWithIndicatorsScenario CreateScenario_FormsWithIndicators(FormsWithIndicatorsArgs? scenarioArgs = null)
        {
            scenarioArgs ??= new FormsWithIndicatorsArgs();
            using var context = new AssessmentContext();

            var indicators = CreateIndicators(scenarioArgs.indicatorsArgs);
            var forms = CreateForms(scenarioArgs.formsArgs);
            var formIndciators = new HashSet<FormIndicator>();

            foreach (var form in forms)
            {
                int count = scenarioArgs.MaxIndicatorsPerForm;

                while (count > 0 || (scenarioArgs.AllowFormsWithoutIndicators == false && form.Indicators.Count() == 0))
                {
                    var indicator = indicators.ElementAt(Faker.Random.Number(0, indicators.Count() - 1));

                    if (Faker.Random.Bool())
                    {
                        count--;
                        continue;
                    }

                    if (formIndciators.Any(fi => fi.Form == form && fi.Indicator == indicator))
                        continue;

                    AssignIndicatorToForm(form, indicator, formIndciators);

                    count--;
                }
            }

            var scenario = new FormsWithIndicatorsScenario
            {
                Indicators = indicators,
                Forms = forms,
                FormIndicators = formIndciators,
            };

            return scenario;
        }

        private static void AssignIndicatorToForm(Form form, Indicator indicator, ICollection<FormIndicator> formIndicators)
        {
            form.Indicators.Add(indicator);
            var groupStudent = new FormIndicator { Form = form, Indicator = indicator };
            form.FromIndicators.Add(groupStudent);
            indicator.FromIndicators.Add(groupStudent);
            indicator.Forms.Add(form);
            formIndicators.Add(groupStudent);
        }
    }

    public class FormsWithIndicatorsScenario : ScenarioBase<FormsWithIndicatorsScenario>
    {
        public IEnumerable<Indicator> Indicators { get; set; } = new HashSet<Indicator>();
        public IEnumerable<Form> Forms { get; set; } = new HashSet<Form>();
        public IEnumerable<FormIndicator> FormIndicators { get; set; } = new HashSet<FormIndicator>();

        protected override void SaveScenario()
        {
            using var context = new AssessmentContext();
            context.Indicators.AddRange(Indicators);
            context.Forms.AddRange(Forms);
            context.FormIndicators.AddRange(FormIndicators);
            context.SaveChanges();
        }

        protected override void RemoveScenario()
        {
            using var context = new AssessmentContext();
            context.FormIndicators.RemoveRange(FormIndicators);
            context.Forms.RemoveRange(Forms);
            context.Indicators.RemoveRange(Indicators);
            context.SaveChanges();
        }
    }

    public class FormsWithIndicatorsArgs : ScenarioArgs
    {
        public EnumerableFakerArgs indicatorsArgs{ get; set; } = new EnumerableFakerArgs();
        public EnumerableFakerArgs formsArgs { get; set; } = new EnumerableFakerArgs();
        public int MaxIndicatorsPerForm { get; set; } = 3;
        public bool AllowFormsWithoutIndicators { get; set; } = false;

        public FormsWithIndicatorsArgs()
        {
        }
    }
}

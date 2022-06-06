using Model;

namespace Service.Database.EntityFaker
{
    public static partial class EntityFaker
    {
        public static Bogus.Faker Faker { get; }
        private static readonly Bogus.Faker<Student> _studentFaker;
        private static readonly Bogus.Faker<Group> _groupFaker;
        private static readonly Bogus.Faker<Indicator> _indicatorFaker;
        private static readonly Bogus.Faker<Form> _formFaker;
        private static readonly Bogus.Faker<Competence> _competenceFaker;
        private static readonly Bogus.Faker<Criterion> _criterionFaker;
        private static readonly Bogus.Faker<Project> _projectFaker;
        public static readonly EntityFakerContained Contained;

        static EntityFaker()
        {
            Faker = new Bogus.Faker();
            Contained = new EntityFakerContained();

            _studentFaker = new Bogus.Faker<Student>()
                .RuleFor(f => f.Name, f => f.Name.FullName());

            _groupFaker = new Bogus.Faker<Group>()
                .RuleFor(f => f.Name, f => f.Company.CompanyName())
                .RuleFor(f => f.Number, f => f.Random.Number(1, 6));

            _indicatorFaker = new Bogus.Faker<Indicator>()
                .RuleFor(f => f.Name, f => {
                    string name;
                    using var context = GetContext();
                    do name = f.Lorem.Word(); while (context.Indicators.Any(i => i.Name == name));
                    return name;
                })
                .RuleFor(f => f.Value, f => f.Random.Number(1, 10));

            _formFaker = new Bogus.Faker<Form>()
                .RuleFor(f => f.Name, f => f.Lorem.Word());

            _competenceFaker = new Bogus.Faker<Competence>()
                .RuleFor(f => f.Name, f => f.Lorem.Word())
                .RuleFor(f => f.Description, f => f.Lorem.Paragraph())
                .RuleFor(f => f.Weight, f => f.Random.Float())
                .RuleFor(f => f.Evidence, f => f.Lorem.Paragraph());

            _projectFaker = new Bogus.Faker<Project>()
                .RuleFor(f => f.Name, f => f.Lorem.Word())
                .RuleFor(f => f.Description, f => f.Lorem.Paragraph())
                .RuleFor(f => f.Code, f => f.Random.Chars().ToString());
        }

        public static AssessmentContext GetContext()
        {
            return new AssessmentContext();
        }
    }
}

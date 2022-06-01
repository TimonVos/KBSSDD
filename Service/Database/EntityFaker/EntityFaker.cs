using Model;

namespace Service.Database.EntityFaker
{
    public static partial class EntityFaker
    {
        public static Bogus.Faker Faker { get; }
        private static readonly Bogus.Faker<Student> _studentFaker;
        private static readonly Bogus.Faker<Group> _groupFaker;
        private static readonly Bogus.Faker<Indicator> _indicatorFaker;
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
        }

        public static AssessmentContext GetContext()
        {
            return new AssessmentContext();
        }
    }
}

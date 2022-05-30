using Model;

namespace Service.Database.EntityFaker
{
    public static partial class EntityFaker
    {
        public static Bogus.Faker Faker { get; }
        private static readonly Bogus.Faker<Student> _studentFaker;
        private static readonly Bogus.Faker<Group> _groupFaker;
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
        }

        public static AssessmentContext GetContext()
        {
            return new AssessmentContext();
        }
    }
}

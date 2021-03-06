using Model;

namespace Service.Database.EntityFaker
{
    /// <summary>
    /// Helper class to create test instances of model. Can be easily used and extended.
    /// </summary>
    public static partial class EntityFaker
    {
        /// <summary>
        /// Instance of Bogus.Faker to help generate data on the spot.
        /// </summary>
        public static Bogus.Faker Faker { get; }
        /// <summary>
        /// 
        /// </summary>
        public static readonly EntityFakerContained Contained;

        #region Bogus fakers

        private static readonly Bogus.Faker<Student> _studentFaker;
        private static readonly Bogus.Faker<Group> _groupFaker;
        private static readonly Bogus.Faker<Indicator> _indicatorFaker;
        private static readonly Bogus.Faker<Form> _formFaker;
        private static readonly Bogus.Faker<Competence> _competenceFaker;
        private static readonly Bogus.Faker<Criterion> _criterionFaker;
        private static readonly Bogus.Faker<Project> _projectFaker;
        private static readonly Bogus.Faker<Requirement> _requirementFaker;

        #endregion

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

            _criterionFaker = new Bogus.Faker<Criterion>()
                .RuleFor(f => f.Name, f => f.Lorem.Word())
                .RuleFor(f => f.Description, f => f.Lorem.Paragraph());

            _projectFaker = new Bogus.Faker<Project>()
                .RuleFor(f => f.Name, f => f.Lorem.Word())
                .RuleFor(f => f.Description, f => f.Lorem.Paragraph())
                .RuleFor(f => f.Code, f => f.Random.Chars().ToString());

            _requirementFaker = new Bogus.Faker<Requirement>()
                .RuleFor(f => f.Name, f => f.Lorem.Word())
                .RuleFor(f => f.Description, f => f.Lorem.Paragraph());
        }

        public static AssessmentContext GetContext()
        {
            return new AssessmentContext();
        }
    }
}

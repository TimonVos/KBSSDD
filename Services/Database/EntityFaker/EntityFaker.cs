using Model;
using Service.Database.EntityFaker.Faker;

namespace Service.Database.EntityFaker
{
    public static partial class EntityFaker
    {
        public static Bogus.Faker Faker { get; }
        private static readonly Bogus.Faker<Student> _studentFaker;

        static EntityFaker()
        {
            Faker = new Bogus.Faker();

            _studentFaker = new Bogus.Faker<Student>()
                .RuleFor(f => f.Name, f => f.Name.FullName());
        }
    }
}

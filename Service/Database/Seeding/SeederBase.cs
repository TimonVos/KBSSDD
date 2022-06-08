using Bogus;
using Microsoft.EntityFrameworkCore;

namespace Service.Database.Seeding
{
    /// <summary>
    /// Base for database seeders.
    /// </summary>
    public abstract class SeederBase
    {
        protected Faker Faker = new Faker();
        /// <summary>
        /// <inheritDoc cref="DbContext.OnModelCreating"/>
        /// </summary>
        /// <param name="modelBuilder"></param>
        public abstract void Seed(ModelBuilder modelBuilder);

        protected static int GetId(ref int id)
        {
            return id == 0 ? 0 : id++;
        }
    }
}

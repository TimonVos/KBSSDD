#if (!DEBUG)
using Bogus;
using Microsoft.EntityFrameworkCore;
using Model;

namespace Service.Database.Seeding
{
    /// <summary>
    /// Seed the database with random data.
    /// </summary>
    public class ReleaseSeeder : SeederBase
    {
        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="modelBuilder"></param>
        public override void Seed(ModelBuilder modelBuilder)
        {

        }
    }
}
#endif

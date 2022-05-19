using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Service.Database.Seeding
{
    /// <summary>
    /// Base for database seeders.
    /// </summary>
    public abstract class SeederBase
    {
        /// <summary>
        /// <inheritDoc cref="DbContext.OnModelCreating"/>
        /// </summary>
        /// <param name="modelBuilder"></param>
        public abstract void Seed(ModelBuilder modelBuilder);
    }
}

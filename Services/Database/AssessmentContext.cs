using Microsoft.EntityFrameworkCore;
using Model;
using Service.Database.Configuration;
using Service.Properties;

namespace Service.Database
{
    public partial class AssessmentContext : DbContext
    {
        #region Entity sets

        /// <summary>
        /// <see cref="Group"/> entity set.
        /// </summary>
        public DbSet<Group> Groups { get; set; } = default!;
        /// <summary>
        /// <see cref="Student"/> entity set.
        /// </summary>
        public DbSet<Student> Students { get; set; } = default!;
        /// <summary>
        /// <see cref="Indicator"/> entity set.
        /// </summary>
        public DbSet<Indicator> Indicators { get; set; } = default!;


        #endregion

        /// <summary>
        /// User configuration for the connection string.
        /// </summary>
        public static string ConnectionString
        {
            get => Settings.Default.ConnectionString;
            set
            {
                Settings.Default.ConnectionString = value;
                Settings.Default.Save();
            }
        }

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="options"></param>
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(ConnectionString);

        /// <summary>
        /// <inheritdoc/>
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new GroupConfiguration());
            modelBuilder.ApplyConfiguration(new IndicatorConfiguration());

#if DEBUG
            new Seeding.DebugSeeder().Seed(modelBuilder);
#endif
        }
    }
}

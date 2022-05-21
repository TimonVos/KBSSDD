using Microsoft.EntityFrameworkCore;
using Model;
using Service.Database.Configuration;
using Service.Properties;

namespace Service.Database
{
    public partial class AssessmentContext : DbContext
    {
        /// <summary>
        /// User setting for the connection string.
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

        #region Entity sets

        /// <summary>
        /// Group entity set.
        /// </summary>
        public DbSet<Group> Groups { get; set; } = default!;
        /// <summary>
        /// Student entity set.
        /// </summary>
        public DbSet<Student> Students { get; set; } = default!;
        /// <summary>
        /// GroupStudent entity set.
        /// </summary>
        public DbSet<GroupStudent> GroupStudents { get; set; } = default!;
        /// <summary>
        /// Indicator entity set.
        /// </summary>
        public DbSet<Indicator> Indicators { get; set; } = default!;
        /// <summary>
        /// Form entity set.
        /// </summary>
        public DbSet<Form> Forms { get; set; } = default!;
        /// <summary>
        /// FormIndicator entity set.
        /// </summary>
        public DbSet<FormIndicator> FormIndicators { get; set; } = default!;
        /// <summary>
        /// <see cref="Competence"/> entity set.
        /// </summary>
        public DbSet<Competence> Competences { get; set; } = default!;
        /// <summary>
        /// <see cref="Criterion"/> entity set.
        /// </summary>
        public DbSet<Criterion> Criteria { get; set; } = default!;
        /*        /// <summary>        /// <see cref="Requirement"/> entity set.
                /// </summary>
                public DbSet<Requirement> Requirements { get; set; } = default!;*/
        /*        /// <summary>
        /// <see cref="Project"/> entity set.
        /// </summary>
        public DbSet<Project> Projects { get; set; } = default!;*/
        /*        /// <summary>
                /// <see cref="Assessment"/> entity set.
                /// </summary>
                public DbSet<Assessment> Assessments { get; set; } = default!;*/
        /*        /// <summary>
        /// <see cref="Rating"/> entity set.
        /// </summary>
        public DbSet<Rating> Ratings { get; set; } = default!;*/


        #endregion

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
            modelBuilder.ApplyConfiguration(new FormConfiguration());
            // modelBuilder.ApplyConfiguration(new RatingConfiguration());

#if DEBUG
            // new Seeding.DebugSeeder().Seed(modelBuilder);
#endif
        }
    }
}

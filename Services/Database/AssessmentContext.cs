using Microsoft.EntityFrameworkCore;
using Model;
using Service.Database.Configuration;
using Service.Properties;

namespace Service.Database
{
    public partial class AssessmentContext : DbContext
    {
        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }

        public static string ConnectionString
        {
            get => Settings.Default.ConnectionString;
            set
            {
                Settings.Default.ConnectionString = value;
                Settings.Default.Save();
            }
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(ConnectionString);

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new GroupConfiguration());
#if DEBUG
            // Seeder.Seed(modelBuilder);
#endif
        }
    }
}

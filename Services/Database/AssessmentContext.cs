using Microsoft.EntityFrameworkCore;
using Model;
using Service;
using Service.Properties;

namespace Service.Database
{
    public class AssessmentContext : DbContext
    {
        public DbSet<Group> Groups { get; set; }

        public static string ConnectionString {
            get => Settings.Default.ConnectionString;
            set
            {
                Settings.Default.ConnectionString = value;
                Settings.Default.Save();
            }
        }

        public AssessmentContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer(ConnectionString);
    }
}

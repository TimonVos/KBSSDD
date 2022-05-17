using Microsoft.EntityFrameworkCore;
using Model;

namespace Service.Database
{
    public class AssessmentContext : DbContext
    {
        public DbSet<Group> Groups { get; set; }

        public AssessmentContext()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer($"Data Source=(LocalDB)\\MSSQLLocalDB;DataBase=assessment;Integrated Security=True;Connect Timeout=30;AttachDbFileName=C:\\temp\\assessment.mdf;");
    }
}

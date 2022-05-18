#if DEBUG
using Microsoft.EntityFrameworkCore;
using Model;

namespace Service.Database
{
    internal static class Seeder
    {
        internal static void debug(ModelBuilder modelBuilder)
        {
            var students = new List<Student> {
                new Student { Number = 116000, Name = "John" },
                new Student { Number = 116001, Name = "Jane" },
            };

            var group = new Group { GroupId = 1, Name = "Foo", Number = 1 };

            var groupStudent = new List<object>
            {
                new { GroupsGroupId = group.GroupId, StudentsNumber = students[0].Number },
                new { GroupsGroupId = group.GroupId, StudentsNumber = students[1].Number },
            };

            modelBuilder.Entity<Student>().HasData(students);
            modelBuilder.Entity<Group>().HasData(group);

            modelBuilder.Entity<Group>()
                .HasMany(g => g.Students)
                .WithMany(s => s.Groups)
                .UsingEntity<Dictionary<string, object>>(
                    "GroupStudent",
                    r => r.HasOne<Student>().WithMany().HasForeignKey("StudentsNumber"),
                    l => l.HasOne<Group>().WithMany().HasForeignKey("GroupsGroupId"),
                    je =>
                    {
                        je.HasKey("GroupsGroupId", "StudentsNumber");
                        je.HasData(groupStudent);
                    }
                );
        }
    }
}
#endif

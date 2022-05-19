using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace Service.Database.Configuration
{
    internal class GroupConfiguration : IEntityTypeConfiguration<Group>
    {
        public void Configure(EntityTypeBuilder<Group> builder)
        {
            builder.HasMany(gs => gs.Students)
                .WithMany(s => s.Groups)
                .UsingEntity<GroupStudent>(
                    r => r
                        .HasOne(gs => gs.Student)
                        .WithMany(s => s.GroupStudents)
                        .HasForeignKey(gs => gs.StudentNumber),
                    l => l
                        .HasOne(gs => gs.Group)
                        .WithMany(g => g.GroupStudents)
                        .HasForeignKey(gs => gs.GroupId),
                    j => j.HasKey(gs => new { gs.GroupId, gs.StudentNumber })
                );
        }
    }

}

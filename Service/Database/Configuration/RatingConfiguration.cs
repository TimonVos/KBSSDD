using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace Service.Database.Configuration
{
    /// <summary>
    /// Configuration for <see cref="GroupStudent"/>.
    /// </summary>
    internal class RatingConfiguration : IEntityTypeConfiguration<Rating>
    {
        public void Configure(EntityTypeBuilder<Rating> builder)
        {
            builder.HasOne(u => u.Criterion).WithMany(u => u.Ratings).IsRequired().OnDelete(DeleteBehavior.Restrict);
            builder.HasOne(u => u.Requirement).WithMany(u => u.Ratings).IsRequired().OnDelete(DeleteBehavior.Restrict);
            builder.HasKey(t => new { t.AssessmentId, t.CriterionId });
        }
    }
}

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace Service.Database.Configuration
{
    /// <summary>
    /// Configuration for <see cref="GroupStudent"/>.
    /// </summary>
    internal class FormConfiguration : IEntityTypeConfiguration<Form>
    {
        public void Configure(EntityTypeBuilder<Form> builder)
        {
            builder
                .HasMany(f => f.Indicators)
                .WithMany(i => i.Forms)
                .UsingEntity<FormIndicator>(
                    r => r
                        .HasOne(fi => fi.Indicator)
                        .WithMany(i => i.FromIndicators)
                        .HasForeignKey(fi => fi.IndicatorId),
                    l => l
                        .HasOne(gs => gs.Form)
                        .WithMany(f => f.FromIndicators)
                        .HasForeignKey(fi => fi.FormId),
                    j => j.HasKey(fi => new { fi.FormId, fi.IndicatorId })
                );
        }
    }
}

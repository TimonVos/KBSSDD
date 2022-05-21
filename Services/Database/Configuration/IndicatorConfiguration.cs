using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Model;

namespace Service.Database.Configuration
{
    /// <summary>
    /// Configuration for <see cref="Indicator"/>.
    /// </summary>
    internal class IndicatorConfiguration : IEntityTypeConfiguration<Indicator>
    {
        public void Configure(EntityTypeBuilder<Indicator> builder)
        {
            builder
                .HasIndex(i => i.Name)
                .IsUnique();
        }
    }
}

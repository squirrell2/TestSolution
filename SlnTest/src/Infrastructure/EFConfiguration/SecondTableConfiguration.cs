using Infrastructure.EFModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EFConfiguration;

public class SecondTableConfiguration : IEntityTypeConfiguration<SecondTable>
{
    #region Implementation of IEntityTypeConfiguration<SecondTable>

    /// <inheritdoc />
    public void Configure(EntityTypeBuilder<SecondTable> builder)
    {
        builder
            .HasIndex(x => x.Name)
            .IsUnique();
    }

    #endregion
}
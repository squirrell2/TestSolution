using Infrastructure.EFModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EFConfiguration
{
    public class SampleTableConfiguration : IEntityTypeConfiguration<SampleTable>
    {
        #region Implementation of IEntityTypeConfiguration<SampleTable>

        /// <inheritdoc />
        public void Configure(EntityTypeBuilder<SampleTable> builder)
        {
        }

        #endregion
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.EFConfiguration;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Data
{
    public class AppDemoContext : DbContext
    {
        /// <inheritdoc />
        public AppDemoContext(DbContextOptions<AppDemoContext> options) : base(options)
        {
        }

        #region Overrides of DbContext

        /// <inheritdoc />
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfigurationsFromAssembly(typeof(SampleTableConfiguration).Assembly);
        }

        #endregion
    }
}

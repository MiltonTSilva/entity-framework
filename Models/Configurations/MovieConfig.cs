using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace entity_framework.Models.Configurations
{
    /// <summary>
    /// 
    /// </summary>
    public class MovieConfig : IEntityTypeConfiguration<Movie>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<Movie> builder)
        {
            builder.Property(d => d.PremiereDate).HasColumnType("date");
        }
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace entity_framework.Models.Configurations
{
    /// <summary>
    /// 
    /// </summary>
    public class ActorConfig : IEntityTypeConfiguration<Actor>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<Actor> builder)
        {
            builder.Property(d => d.BirthDate).HasColumnType("date");
            builder.Property(f => f.Fortune).HasPrecision(18,2);
        }
    }
}
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace entity_framework.Models.Configurations
{
    /// <summary>
    /// 
    /// </summary>
    public class CommentConfig : IEntityTypeConfiguration<Comment>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<Comment> builder)
        {
           builder.Property(d => d.Content).HasMaxLength(500);
        }
    }
}
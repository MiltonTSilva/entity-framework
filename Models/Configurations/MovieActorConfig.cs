using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace entity_framework.Models.Configurations
{
    /// <summary>
    /// 
    /// </summary>
    public class MovieActorConfig : IEntityTypeConfiguration<MovieActor>
    {
        /// <summary>
        /// 
        /// </summary>
        /// <param name="builder"></param>
        public void Configure(EntityTypeBuilder<MovieActor> builder)
        {
            builder.HasKey(ma => new{ ma.MovieId, ma.ActorId});
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace entity_framework;

/// <summary>
/// 
/// </summary>
public class AppDbContext: DbContext {

    private readonly IConfiguration _configuration;

    /// <summary>
    /// 
    /// </summary>
    /// <param name="configuration"></param>
    public AppDbContext(IConfiguration configuration)
    {
        _configuration = configuration;
    }

    /// <summary>
    /// 
    /// </summary>
    public DbSet<Actor> Actors => Set<Actor>();
    /// <summary>
    /// 
    /// </summary>
    public DbSet<Comment> Comments => Set<Comment>();
    /// <summary>
    /// 
    /// </summary>
    public DbSet<Genre> Genres => Set<Genre>();
    /// <summary>
    /// 
    /// </summary>
    public DbSet<Movie> Movies => Set<Movie>();
    /// <summary>
    /// 
    /// </summary>
    public DbSet<MovieActor> MoviesActors => Set<MovieActor>();

    /// <summary>
    /// 
    /// </summary>
    /// <param name="optionsBuilder"></param>
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);

        optionsBuilder.UseSqlite(_configuration.GetConnectionString("DefaultConnection"));

    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="configurationBuilder"></param>
    protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
    {
        base.ConfigureConventions(configurationBuilder);

        configurationBuilder.Properties<string>().HaveMaxLength(150);
    }

    /// <summary>
    /// 
    /// </summary>
    /// <param name="modelBuilder"></param>
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }

}
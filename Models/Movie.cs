namespace entity_framework;

/// <summary>
/// 
/// </summary>
public class Movie {
    
    /// <summary>
    /// 
    /// </summary>
    public int Id { get; set; }
    
/// <summary>
    /// 
    /// </summary>
    public string? Name { get; set; } = null;
    
    /// <summary>
    /// 
    /// </summary>
    public string? Title { get; set; } = null;
    
    /// <summary>
    /// 
    /// </summary>
    public bool AtTheMovies { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    public DateTime PremiereDate { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    public DateTime CreationDate { get; set; } = DateTime.Now;
    
    /// <summary>
    /// 
    /// </summary>
    public HashSet<Comment> Comments { get; set; } = new HashSet<Comment>();
    
    /// <summary>
    /// 
    /// </summary>
    public HashSet<Genre> Genres { get; set; } = new HashSet<Genre>();
    
    /// <summary>
    /// 
    /// </summary>
    public List<MovieActor> MoviesActors { get; set; } = new List<MovieActor>();
}
namespace entity_framework;

/// <summary>
/// 
/// </summary>
public class Genre {
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
    public DateTime CreationDate { get; set; } = DateTime.Now;
    /// <summary>
    /// 
    /// </summary>
    public HashSet<Movie> Moviess { get; set; }= new HashSet<Movie>();
}
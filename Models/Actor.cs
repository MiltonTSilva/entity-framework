namespace entity_framework;

/// <summary>
/// 
/// </summary>
public class Actor {
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
    public decimal Fortune  { get; set; }
    /// <summary>
    /// /
    /// </summary>
    public DateTime BirthDate { get; set; }
    /// <summary>
    /// 
    /// </summary>
    public DateTime CreationDate { get; set; } = DateTime.Now;
    /// <summary>
    /// 
    /// </summary>
    public List<MovieActor> MoviesActors { get; set; } = new List<MovieActor>();
}
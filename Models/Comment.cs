namespace entity_framework;

/// <summary>
/// 
/// </summary>
public class Comment {
    
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
    public string? Content { get; set; } = null;

    /// <summary>
    /// 
    /// </summary>
    public bool ToRecommend { get; set; }

    /// <summary>
    /// 
    /// </summary>
    public DateTime CreationDate { get; set; } = DateTime.Now;

    /// <summary>
    /// 
    /// </summary>
    public int MovieId  { get; set; }
    
    /// <summary>
    /// 
    /// </summary>
    public Movie? Movie { get; set; } = null;
}
using System.ComponentModel.DataAnnotations;

namespace entity_framework.ViewModels;
/// <summary>
/// 
/// </summary>
public class GenreModel
{
    /// <summary>
    /// 
    /// </summary>
    [StringLength(maximumLength: 150)]
    public string Name { get; set; } = null!;
}

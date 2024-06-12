using System.ComponentModel.DataAnnotations;
using Type = Alina.Enums.Type;

namespace Alina.Models;

public class SectionItem : BaseModel
{
    [Required]
    public string Name { get; set; } = string.Empty;
    [Required]
    public Guid SectionID { get; set; }

    public Section Section { get; set; }
    public Type Type { get; set; }
    
    public List<Content> Contents { get; set; }
}
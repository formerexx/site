using System.ComponentModel.DataAnnotations;

namespace Alina.Models;

public class Content: BaseModel
{
    public string Description { get; set; } = String.Empty;
    [MaxLength(150)]
    public string Hyperlink { get; set; } = String.Empty;
    [Required]

    public SectionItem SectionItem{ get; set; }
    [Required]
    public Guid SectioniItemID { get; set; }
    public List<Heading> Headings { get; set; }
}
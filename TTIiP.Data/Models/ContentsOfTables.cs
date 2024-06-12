using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Alina.Models;

public class ContentsOfTables:  BaseModel
{
    public string Content { get; set; } = String.Empty;
    [Required]
    public Guid  HeadingId { get; set; }
    public Heading Heading { get; set; }
}
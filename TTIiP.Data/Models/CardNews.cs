using System.ComponentModel.DataAnnotations;

namespace Alina.Models;

public class CardNews : BaseModel
{
    [MaxLength(50)]
    public string Name { get; set; } = String.Empty;
    public DateTime Date { get; set; }
    public string Author { get; set; } = String.Empty;
    public string Hyperlink { get; set; } = String.Empty;
    [Required]
    public Guid SectionID { get; set; }
    public Section Section { get; set; }
    //[Required]
    //public Guid NewsID { get; set; }
    public News News { get; set; }
}
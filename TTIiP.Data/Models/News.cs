using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Alina.Models;
[Table("News")]

public class News : BaseModel
{
    
    public string Content { get; set; } = String.Empty;
    //[Required]
    //public Guid CardNewsID { get; set; }

    public CardNews CardNews { get; set; }
}
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Alina.Models;

public class Heading : BaseModel
{
   
    [MaxLength(150)]
    
    public string ContentHeading { get; set; } = String.Empty;
    [Required]
    
    public Guid ContentID { get; set; }
    public Content Content{ get; set; }
    private List<ContentsOfTables> ContentsOfTables { get; set; }

}
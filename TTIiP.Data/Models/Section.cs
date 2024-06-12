using System.ComponentModel.DataAnnotations;

namespace Alina.Models;

public class Section: BaseModel
{
    [MaxLength(30)]
    public string Name { get; set; } = string.Empty;
    
    
}
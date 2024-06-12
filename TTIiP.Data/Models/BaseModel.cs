using System.ComponentModel.DataAnnotations;

namespace Alina.Models;

public abstract class BaseModel: IBaseModel
{
    protected BaseModel()
    {
        Id = Guid.NewGuid();
        DateCreate = DateTime.Now;
        UpDateChange = DateTime.Now;
    }
    [Key]
    public Guid Id { get; set; }
    public DateTime DateCreate { get; set; }
    public DateTime UpDateChange { get; set; }
}
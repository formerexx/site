namespace Alina.Models;

public interface IBaseModel
{
    Guid Id { get; }
    public DateTime DateCreate { get; }
    public DateTime UpDateChange { get; }
}
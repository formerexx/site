using Alina.Models;

namespace OA.Service.Interface;

public interface IBaseService<T> where T : BaseModel
{
    void Add(T entity);
    bool Update(T entity);
    bool Delete(T entity);
    T Get(Guid id);
    IEnumerable<T> GetAll();

}
using Alina.Models;

namespace TTIiP.Repository.Interface;

public interface IRepository<T> where T : BaseModel
{
    IEnumerable<T> GetAll();
    T Get(Guid id);
    void Add(T entity);
    bool Update(T entity);
    bool Delete(T entity);

 
}
using Alina.Models;
using TTIiP.Repository.Interface;


namespace TTIiP.Repository.Implementation;

public class Repository<T>: IRepository<T> where T : BaseModel
{
    private readonly ApplicationContext entities;   


    public Repository(ApplicationContext aplicationContext)
    {
        entities = aplicationContext;
    }
    public IEnumerable<T> GetAll()
    {
        return entities.Set<T>().ToList();
    }

    public T Get(Guid id)
    {
        return entities.Set<T>().SingleOrDefault(s => s.Id == id);
    }

    public void Add(T entity)
    {
        entities.Set<T>().Add(entity);
        entities.SaveChanges();
    }

    public bool Update(T entity)
    {
        try
        {
            entities.Set<T>().Update(entity);
            entities.SaveChanges();
            return true;
        }
        catch
        {
            return false;
        } 
        
        
    }
    public bool Delete(T entity)
    {
        try
        {
            entities.Remove(entity);
            entities.SaveChanges();
            return true;
        }
        catch
        {
            return false;
        } 
    }

   
}
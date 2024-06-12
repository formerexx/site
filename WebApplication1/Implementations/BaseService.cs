using Alina.Models;
using OA.Service.Interface;
using TTIiP.Repository.Interface;

namespace WebApplication1.Implementations;

public class BaseService<T> : IBaseService<T> where T : BaseModel
{
    private IRepository<T> SectionRepository;

    public BaseService(IRepository<T> sectionRepository)
    {
        this.SectionRepository = sectionRepository;
    }
    public void Add(T entity)
    {
        SectionRepository.Add(entity);
    }

    public bool Update(T entity)
    {
        try
        {
            SectionRepository.Update(entity);
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
            var section = SectionRepository.Get(entity.Id);
            SectionRepository.Delete(section);
            return true;
        }
        catch 
        {
            return false;
        }
    }

    public T Get(Guid id )
    {
        return  SectionRepository.Get(id);
    }

    public IEnumerable<T> GetAll()
    {
       return SectionRepository.GetAll();
    }
}

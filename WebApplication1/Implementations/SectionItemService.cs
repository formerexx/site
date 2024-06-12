using Alina.Models;
using OA.Service.Interface;
using TTIiP.Repository.Interface;
using WebApplication1.Implementations;

namespace OA.Service.Implementations;

public class SectionItemService: BaseService<SectionItem>, ISectionItemService
{
    public SectionItemService(IRepository<SectionItem> sectionRepository) : base(sectionRepository)
    {
    }
}
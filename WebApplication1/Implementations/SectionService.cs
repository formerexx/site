using Alina.Models;
using OA.Service.Implementations;
using OA.Service.Interface;
using TTIiP.Repository.Interface;

namespace WebApplication1.Implementations;

public class SectionService: BaseService<Section>, ISectionService
{
    public SectionService(IRepository<Section> sectionRepository) : base(sectionRepository)
    {
    }
}
using Alina.Models;
using OA.Service.Interface;
using TTIiP.Repository.Interface;
using WebApplication1.Implementations;

namespace OA.Service.Implementations;

public class HeadingService: BaseService<Heading>, IHeadingService
{
    public HeadingService(IRepository<Heading> sectionRepository) : base(sectionRepository)
    {
    }
}
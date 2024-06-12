using Alina.Models;
using OA.Service.Interface;
using TTIiP.Repository.Interface;
using WebApplication1.Implementations;

namespace OA.Service.Implementations;

public class ContentsOfTablesService: BaseService<ContentsOfTables>, IContentsOfTablesService
{
    public ContentsOfTablesService(IRepository<ContentsOfTables> sectionRepository) : base(sectionRepository)
    {
    }
}




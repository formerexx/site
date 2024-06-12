using Alina.Models;
using OA.Service.Interface;
using TTIiP.Repository.Interface;
using WebApplication1.Implementations;

namespace OA.Service.Implementations;

public class ContentServiceService : BaseService<Content>, IContentService
{
    public ContentServiceService(IRepository<Content> sectionRepository) : base(sectionRepository)
    {
    }
}
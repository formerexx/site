using Alina.Models;
using OA.Service.Implementations;
using OA.Service.Interface;
using TTIiP.Repository.Interface;

namespace WebApplication1.Implementations;

public class CardNewsService : BaseService<CardNews>, ICardNewsService
{
    public CardNewsService(IRepository<CardNews> cardnews ) : base (cardnews)
    {
    }
}
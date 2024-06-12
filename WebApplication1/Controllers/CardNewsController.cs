using Alina.Models;
using Microsoft.AspNetCore.Mvc;
using OA.Service.Interface;

namespace WebApplication1.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CardNewsController : Controller
{
    private readonly ICardNewsService _cardNews;

    public CardNewsController(ICardNewsService cardNews)
    {
        _cardNews = cardNews;
    }
    /// <summary>
    ///     Добавление нового объявления
    /// </summary>
    /// <param name="request">Запрос на создание объявления</param>
    /// <returns>Результат операции</returns>
    [HttpPost("Add")]
    [ProducesResponseType(StatusCodes.Status200OK)] // Возвращает успешный статус при успешном добавлении объявления
    [ProducesResponseType(StatusCodes
        .Status500InternalServerError)] // Возвращает статус ошибки сервера при внутренней ошибке
    public  IActionResult Add([FromBody] CardNews request)
    {
         _cardNews.Add(request);
        return Ok();
    }
    [HttpGet("Get")]
    [ProducesResponseType(typeof(IEnumerable<CardNews>),
        StatusCodes.Status200OK)] // Возвращает список объявлений при успешном запросе
    [ProducesResponseType(StatusCodes
        .Status500InternalServerError)] // Возвращает статус ошибки сервера при внутренней ошибке
    public IActionResult GetAds()
    {
        return Ok( _cardNews.GetAll());
    }
    [HttpDelete("Delete")]
    [ProducesResponseType(StatusCodes.Status200OK)] // Возвращает успешный статус при успешном удалении объявления
    [ProducesResponseType(StatusCodes
        .Status500InternalServerError)] // Возвращает статус ошибки сервера при внутренней ошибке
    public IActionResult Delete([FromBody] CardNews request)
    { 
        _cardNews.Delete(request);
        return Ok("Успешно удалено");
    }
    
    [HttpPut("Update")]
    [ProducesResponseType(StatusCodes.Status200OK)] // Возвращает успешный статус при успешном обновлении объявления
    [ProducesResponseType(StatusCodes
        .Status500InternalServerError)] // Возвращает статус ошибки сервера при внутренней ошибке
    public IActionResult Put([FromBody] CardNews request)
    {
        var ads =  _cardNews.Update(request);
        return Ok(ads);
    }
}




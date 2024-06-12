using Alina.Models;
using Microsoft.AspNetCore.Mvc;
using OA.Service.Interface;

namespace WebApplication1.Controllers;
[Route("api/[controller]")]
[ApiController]
public class SectionController : ControllerBase
{
    private readonly ISectionService _section;

    public SectionController(ISectionService section)
    {
        _section = section;
    }
    /// <summary>
    ///     Добавление нового объявления
    /// </summary>
    /// <param name="request">Запрос на создание объявления</param>
    /// <returns>Результат операции</returns>
    [HttpPost("Add")]
    public  IActionResult Add([FromBody] Section request)
    {
        _section.Add(request);
        return Ok();
    }
    [HttpGet("Get")]
    [ProducesResponseType(typeof(IEnumerable<CardNews>),
        StatusCodes.Status200OK)] // Возвращает список объявлений при успешном запросе
    [ProducesResponseType(StatusCodes
        .Status500InternalServerError)] // Возвращает статус ошибки сервера при внутренней ошибке
    public IActionResult GetAds()
    {
        return Ok( _section.GetAll());
    }
    [HttpDelete("Delete")]
    [ProducesResponseType(StatusCodes.Status200OK)] // Возвращает успешный статус при успешном удалении объявления
    [ProducesResponseType(StatusCodes
        .Status500InternalServerError)] // Возвращает статус ошибки сервера при внутренней ошибке
    public IActionResult Delete([FromBody] Section request)
    {
        _section.Delete(request);
        return Ok("Успешно удалено");
    }
    
    [HttpPut("Update")]
    [ProducesResponseType(StatusCodes.Status200OK)] // Возвращает успешный статус при успешном обновлении объявления
    [ProducesResponseType(StatusCodes
        .Status500InternalServerError)] // Возвращает статус ошибки сервера при внутренней ошибке
    public IActionResult Put([FromBody] Section request)
    {
        var ads =  _section.Update(request);
        return Ok(ads);
    }
}
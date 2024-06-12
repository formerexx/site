using Alina.Models;
using Microsoft.EntityFrameworkCore;
using OA.Service.Implementations;
using OA.Service.Interface;
using TTIiP.Repository;
using TTIiP.Repository.Implementation;
using TTIiP.Repository.Interface;
using WebApplication1.Implementations;

var builder = WebApplication.CreateBuilder(args);
builder.Configuration.AddJsonFile("appsettings.json");
// Получение строки подключения из конфигурации
string connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
Console.WriteLine(connectionString);
// Регистрация DbContextOptions
builder.Services.AddDbContext<ApplicationContext>(options =>
    options.UseNpgsql(connectionString));
builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped<ICardNewsService, CardNewsService>();
builder.Services.AddScoped<ISectionItemService, SectionItemService>();
builder.Services.AddScoped<ISectionService, SectionService>();


// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
//builder.Services.AddScoped<CardNewsService>(); // Добавьте ваш сервис
builder.Services.AddSwaggerGen();
builder.Services.AddControllers();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseRouting();
app.MapControllers();
app.Run();



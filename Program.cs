using RocketseatAPI.UseCases;
using RocketseatAPI.Infrastructure;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();

// Configura o Banco de Dados em Memória (ou SQLite) para o teste
builder.Services.AddDbContext<RocketseatDbContext>(options => 
    options.UseInMemoryDatabase("HealthCheckDb"));

// Injeção de Dependência do UseCase
builder.Services.AddScoped<IGetHealthCheckUseCase, GetHealthCheckUseCase>();

var app = builder.Build();

app.MapControllers();

app.Run();

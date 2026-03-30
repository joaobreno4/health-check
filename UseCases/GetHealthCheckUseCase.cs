using Microsoft.EntityFrameworkCore;
using RocketseatAPI.Communication;
using RocketseatAPI.Infrastructure;

namespace RocketseatAPI.UseCases;

public interface IGetHealthCheckUseCase
{
    Task<ResponseHealthCheckJson> Execute();
}

public class GetHealthCheckUseCase : IGetHealthCheckUseCase
{
    private readonly RocketseatDbContext _context; 
    private readonly IWebHostEnvironment _env;
    private static readonly DateTime _startedAt = DateTime.UtcNow;

    public GetHealthCheckUseCase(RocketseatDbContext context, IWebHostEnvironment env)
    {
        _context = context;
        _env = env;
    }

    public async Task<ResponseHealthCheckJson> Execute()
    {
        return new ResponseHealthCheckJson
        {
            Version = "1.0.0.0",
            Environment = _env.EnvironmentName,
            ApplicationStartedAt = _startedAt,
            DatabaseConnected = await CheckDb()
        };
    }

    private async Task<bool> CheckDb()
    {
        try { return await _context.Database.CanConnectAsync(); }
        catch { return false; }
    }
}

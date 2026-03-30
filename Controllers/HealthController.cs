using Microsoft.AspNetCore.Mvc;
using RocketseatAPI.UseCases;

namespace RocketseatAPI.Controllers;

[ApiController]
[Route("health")]
public class HealthController : ControllerBase
{
    [HttpGet("check")]
    public async Task<IActionResult> Check([FromServices] IGetHealthCheckUseCase useCase)
    {
        var result = await useCase.Execute();
        return Ok(result);
    }
}

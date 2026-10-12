using Microsoft.AspNetCore.Mvc;
using CincyGuard.Server.Services;

namespace CincyGuard.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CrimeController : ControllerBase
{
    private readonly CrimeApiService _service;

    public CrimeController(CrimeApiService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetCrimeData()
    {
        var data = await _service.GetCrimeDataAsync();
        return Ok(data);
    }
}

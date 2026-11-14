using Microsoft.AspNetCore.Mvc;
using CincyGuard.Server.Services;
using CincyGuard.Server.Models;

namespace CincyGuard.Server.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class CrimeController : ControllerBase
{
    private readonly CrimeApiService _service;
    private readonly IFilterService _filterService;

    public CrimeController(CrimeApiService service, IFilterService filterService)
    {
        _service = service;
        _filterService = filterService;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<CrimeIncident>>> GetCrimesByFilter([FromQuery] CrimeFilter filters)
    {
        var crimes = await _filterService.GetFilteredCrimesAsync(filters);
        return crimes;
    }

    [HttpGet]
    public async Task<IActionResult> GetCrimeData()
    {
        var data = await _service.GetCrimeDataAsync();
        return Ok(data);
    }
}

using Microsoft.AspNetCore.Mvc;
using CincyGuard.Server.Services;
using CincyGuard.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace CincyGuard.Server.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class CrimeController : ControllerBase
{
    private readonly CrimeApiService _service;
    private readonly CrimeContext _context;

    public CrimeController(CrimeApiService service, CrimeContext context)
    {
        _service = service;
        _context = context;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<CrimeIncident>>> GetAllCrimes() =>
        await _context.Crimes.ToListAsync();

    [HttpGet]
    public async Task<ActionResult<CrimeIncident>> GetCrimeByID(int id)
    {
        var crime = await _context.Crimes.FindAsync(id);
        return crime == null ? NotFound() : crime;
    }

    [HttpGet]
    public async Task<ActionResult<IEnumerable<CrimeIncident>>> GetCrimesByNeighborhood(string neighborhood)
    {
        var crimes = await _context.Crimes.Where(c => c.snaneighborhood == neighborhood).ToListAsync();
        return crimes;
    }

    [HttpGet]
    public async Task<IActionResult> GetCrimeData()
    {
        var data = await _service.GetCrimeDataAsync();
        return Ok(data);
    }
}

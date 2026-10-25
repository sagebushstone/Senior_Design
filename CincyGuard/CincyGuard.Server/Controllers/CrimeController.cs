using Microsoft.AspNetCore.Mvc;
using CincyGuard.Server.Services;
using CincyGuard.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace CincyGuard.Server.Controllers;

[ApiController]
[Route("api/[controller]")]
public class CrimeController : ControllerBase
{
    private readonly CrimeApiService _service;
    private readonly CrimeContext _context;

    public CrimeController(CrimeApiService service, CrimeContext context)
    {
        _service = service;
        _context = context;
    }

    [HttpGet("crimes")]
    public async Task<ActionResult<IEnumerable<CrimeIncident>>> GetAllCrimes() =>
        await _context.Crimes.ToListAsync();

    [HttpGet("{id}")]
    public async Task<ActionResult<CrimeIncident>> GetCrimeByID(int id)
    {
        var emp = await _context.Crimes.FindAsync(id);
        return emp == null ? NotFound() : emp;
    }

    [HttpGet]
    public async Task<IActionResult> GetCrimeData()
    {
        var data = await _service.GetCrimeDataAsync();
        return Ok(data);
    }
}

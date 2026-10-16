using Microsoft.EntityFrameworkCore;
using CincyGuard.Server.Models;

namespace CincyGuard.Server.Services
{
    public class CrimeDbSeeder
    {
        private readonly CrimeContext _context;
        private readonly CrimeApiService _apiService;

        public CrimeDbSeeder(CrimeContext context, CrimeApiService apiService)
        {
            _context = context;
            _apiService = apiService;
        }

        public async Task SeedDb()
        {
            if(await _context.Crimes.AnyAsync())
            {
                return; // don't populate database if there are already records in there
            }

            var incidents = await _apiService.GetCrimeDataAsync();

            await _context.Crimes.AddRangeAsync(incidents);
            await _context.SaveChangesAsync();
        }
    }
}

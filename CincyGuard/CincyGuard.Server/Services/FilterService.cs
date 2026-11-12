using Microsoft.AspNetCore.Mvc;
using CincyGuard.Server.Services;
using CincyGuard.Server.Models;
using Microsoft.EntityFrameworkCore;

namespace CincyGuard.Server.Services
{
    public class FilterService : IFilterService
    {
        private readonly CrimeContext _context;
        public FilterService (CrimeContext context)
        {
            _context = context;
        }

        public async Task<List<CrimeIncident>> GetFilteredCrimesAsync (CrimeFilter filters)
        {
            IQueryable<CrimeIncident> query = _context.Crimes.AsNoTracking();
            
            if(filters.Neighborhood?.Any() == true)
                query = query.Where(c => filters.Neighborhood.Contains(c.snaneighborhood));

            if(filters.CrimeType?.Any() == true)
                query = query.Where(c => filters.CrimeType.Contains(c.starscategory));

            if (filters.DateFrom.HasValue)
                query = query.Where(c => c.eventdate >= filters.DateFrom.Value);

            if (filters.DateTo.HasValue)
                query = query.Where(c => c.eventdate <= filters.DateTo.Value);

            return await query.ToListAsync();
        }
    }
}

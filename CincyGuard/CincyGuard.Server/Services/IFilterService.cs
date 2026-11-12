using CincyGuard.Server.Models;

namespace CincyGuard.Server.Services
{
    // this is an interface creating some abstraction from the FilterService in case we decide we want to change the filtering process later.
    public interface IFilterService
    {
        Task<List<CrimeIncident>> GetFilteredCrimesAsync(
            CrimeFilter filters);
    }
}

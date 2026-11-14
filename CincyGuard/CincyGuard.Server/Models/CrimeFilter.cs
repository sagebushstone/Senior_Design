namespace CincyGuard.Server.Models
{
    public class CrimeFilter
    {
        public List<string>? CrimeType { get; set; }
        public List<string>? Neighborhood { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }

    }
}

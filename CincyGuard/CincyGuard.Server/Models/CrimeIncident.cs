namespace CincyGuard.Server.Models;

public class CrimeIncident
{
    public int Id { get; set; }
    public string? reportnumber { get; set; }
    public DateTime? reportdate { get; set; }
    public string? reportstatus { get; set; }
    public string? starscategory { get; set; }
    public string? starscategorytype { get; set; }
    public string? policedistrct { get; set; }
    public string? eventdate { get; set; }
    public double? lat_x { get; set; }
    public double? lon_x { get; set; }
    public string? snaneighborhood { get; set; }
    public string? addressx { get; set; }
    
}

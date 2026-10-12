namespace CincyGuard.Server.Models;

public class CrimeIncident
{
    public string incident_no { get; set; }
    public string offense { get; set; }
    public string description { get; set; }
    public string address { get; set; }
    public string neighborhood { get; set; }
    public string police_district { get; set; }
    public string reported_date { get; set; }

    public string latitude { get; set; }
    public string longitude { get; set; }

    public Location location { get; set; }
}

namespace CincyGuard.Server.Models;

public class CrimeIncident
{
    public string incident_no { get; set; }
    public string datereported { get; set; }
    public string datefrom { get; set; }
    public string dateto { get; set; }
    public string beat { get; set; }
    public string clsd { get; set; }
    public string stars_category { get; set; }
    public string day_of_week { get; set; }
    public string cpd_neighborhood { get; set; }
    public string hour_from { get; set; }
    public string hour_to { get; set; }
    public string type { get; set; }
    public string sna_neighborhood { get; set; }
    public string cc_neighborhood { get; set; }
    public string address_x { get; set; }
    public string latitude_x { get; set; }
    public string longitude_x { get; set; }
}

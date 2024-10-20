namespace WeatherServiceUserInterface.Entities.External.Locations.Common;

public class Location
{
    public int version { get; set; }
    public string key { get; set; }
    public string type { get; set; }
    public int rank { get; set; }
    public string localizedName { get; set; }
    public string englishName { get; set; }
    public string primaryPostalCode { get; set; }
    public Region region { get; set; }
    public Country country { get; set; }
    public Administrativearea administrativeArea { get; set; }
    public Timezone timeZone { get; set; }
    public Geoposition geoPosition { get; set; }
    public bool isAlias { get; set; }
    public Supplementaladminarea[] supplementalAdminAreas { get; set; }
    public string[] dataSets { get; set; }
}

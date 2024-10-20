namespace WeatherServiceUserInterface.Entities.External.Locations.Common;

public class Timezone
{
    public string code { get; set; }
    public string name { get; set; }
    public float gmtOffset { get; set; }
    public bool isDaylightSaving { get; set; }
    public DateTime? nextOffsetChange { get; set; }
}

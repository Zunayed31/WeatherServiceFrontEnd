using WeatherServiceUserInterface.Entities.External.Locations.Common;

namespace WeatherServiceUserInterface.Entities.External.Locations.GetTopLocations;

public class ExtGetTopLocationsResponse
{
    public List<Location> locations { get; set; }
    public int statusCode { get; set; }
}
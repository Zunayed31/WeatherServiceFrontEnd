using WeatherServiceUserInterface.Entities.External.Forecasts;
using WeatherServiceUserInterface.Entities.External.Locations.GetTopLocations;

namespace WeatherServiceUserInterface.Repositories.Interfaces
{
    public interface IWeatherRepository
    {
        Task<ExtGetTopLocationsResponse> GetTopLocations(int group);
        Task<ExtGetDayForecastResponse> GetDayForecast(int locationKey);
    }
}

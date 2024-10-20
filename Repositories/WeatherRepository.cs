using RestWrapper;
using System.Text.Json;
using WeatherServiceUserInterface.Entities.External.Forecasts;
using WeatherServiceUserInterface.Entities.External.Locations.GetTopLocations;
using WeatherServiceUserInterface.Repositories.Interfaces;

namespace WeatherServiceUserInterface.Repositories
{
    public class WeatherRepository : IWeatherRepository
    {
        #region GetTopLocations

        public async Task<ExtGetTopLocationsResponse> GetTopLocations(int group)
        {
            // simple GET example
            var req = new RestRequest($"https://localhost:44385/WeatherForecast/location/{group}");
            var resp = await req.SendAsync();

            var locations = JsonSerializer.Deserialize<ExtGetTopLocationsResponse>(resp.DataAsString);

            return locations;
        }

        #endregion GetTopLocations

        #region GetDayForecast

        public async Task<ExtGetDayForecastResponse> GetDayForecast(int locationKey)
        {
            // simple GET example
            var req = new RestRequest($"https://localhost:44385/WeatherForecast/forecast/{locationKey}");
            var resp = await req.SendAsync();

            var forecast = JsonSerializer.Deserialize<ExtGetDayForecastResponse>(resp.DataAsString);

            return forecast;
        }

        #endregion GetDayForecast
    }
}

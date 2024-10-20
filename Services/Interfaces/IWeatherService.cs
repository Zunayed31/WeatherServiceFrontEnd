using WeatherServiceUserInterface.Models.ViewModel;

namespace WeatherServiceUserInterface.Services.Interfaces;

public interface IWeatherService
{
    public Task<GetTopLocationsViewModel> GetTopLocations(int group);
    public Task<GetDayForecastResponseViewModel> GetDayForecast(int locationKey);
}

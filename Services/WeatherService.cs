using WeatherServiceUserInterface.Models.ViewModel;
using WeatherServiceUserInterface.Repositories.Interfaces;
using WeatherServiceUserInterface.Services.Interfaces;

namespace WeatherServiceUserInterface.Services;

public class WeatherService : IWeatherService
{
    private IWeatherRepository _weatherRepository;

    public WeatherService(IWeatherRepository weatherRepository)
    {
        _weatherRepository = weatherRepository;
    }

    #region GetTopLocations

    public async Task<GetTopLocationsViewModel> GetTopLocations(int group)
    {
        var repoResponse = await _weatherRepository.GetTopLocations(group);

        return new GetTopLocationsViewModel() 
        {
            Locations = repoResponse.locations
        };
    }

    #endregion GetTopLocations

    #region GetDayForecast

    public async Task<GetDayForecastResponseViewModel> GetDayForecast(int locationKey)
    {
        var repoResponse = await _weatherRepository.GetDayForecast(locationKey);

        return new GetDayForecastResponseViewModel() 
        {
            Forecast = repoResponse.forecast
        };
    }

    #endregion GetDayForecast        

}

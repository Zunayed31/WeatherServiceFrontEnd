using WeatherServiceUserInterface.Entities.External.Forecasts.Common;

namespace WeatherServiceUserInterface.Entities.External.Forecasts
{
    public class ExtGetDayForecastResponse
    {
        public Forecast forecast { get; set; }
        public int statusCode { get; set; }
    }
}

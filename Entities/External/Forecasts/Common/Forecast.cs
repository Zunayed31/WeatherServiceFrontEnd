namespace WeatherServiceUserInterface.Entities.External.Forecasts.Common
{
    public class Forecast
    {
        public Headline headline { get; set; }
        public Dailyforecast[] dailyForecasts { get; set; }
    }

}

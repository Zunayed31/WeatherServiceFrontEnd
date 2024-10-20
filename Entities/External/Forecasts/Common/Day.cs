namespace WeatherServiceUserInterface.Entities.External.Forecasts.Common
{
    public class Day
    {
        public int icon { get; set; }
        public string iconPhrase { get; set; }
        public bool hasPrecipitation { get; set; }
        public object precipitationType { get; set; }
        public object precipitationIntensity { get; set; }
    }

}

namespace WeatherServiceUserInterface.Entities.External.Forecasts.Common
{
    public class Headline
    {
        public DateTime effectiveDate { get; set; }
        public int effectiveEpochDate { get; set; }
        public int severity { get; set; }
        public string text { get; set; }
        public string category { get; set; }
        public DateTime endDate { get; set; }
        public int endEpochDate { get; set; }
        public string mobileLink { get; set; }
        public string link { get; set; }
    }

}

namespace WeatherServiceUserInterface.Entities.External.Forecasts.Common
{
    public class Dailyforecast
    {
        public DateTime date { get; set; }
        public int epochDate { get; set; }
        public Temperature temperature { get; set; }
        public Day day { get; set; }
        public Night night { get; set; }
        public string[] sources { get; set; }
        public string mobileLink { get; set; }
        public string link { get; set; }
    }

}

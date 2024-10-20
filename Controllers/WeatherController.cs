using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WeatherServiceUserInterface.Models;
using WeatherServiceUserInterface.Services.Interfaces;

namespace WeatherServiceUserInterface.Controllers
{
    public class WeatherController : Controller
    {
        private readonly ILogger<WeatherController> _logger;
        private readonly IWeatherService _weatherService;

        public WeatherController(ILogger<WeatherController> logger, IWeatherService weatherService)
        {
            _weatherService = weatherService;
            _logger = logger;
        }

        public async Task<IActionResult> Dashboard()
        {
            var model = await _weatherService.GetTopLocations(50);
            return View(model);
        }

        public async Task<IActionResult> Forecast(string locationKey, string city)
        {
            var model = await _weatherService.GetDayForecast(int.Parse(locationKey));
            ViewBag.City = city;

            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

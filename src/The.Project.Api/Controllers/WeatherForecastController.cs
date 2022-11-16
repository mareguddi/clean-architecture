using Microsoft.AspNetCore.Mvc;
using The.Project.Api.ViewModels;
using The.Project.Domain.Services;

namespace The.Project.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IWeatherForecastService _weatherForecastService;
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherForecastService weatherForecastService)
        {
            _logger = logger;
            _weatherForecastService = weatherForecastService;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            var data = _weatherForecastService.GetAsync();
            return data.Result.ToList().Select(WeatherForecast.FromModel);
        }
    }
}
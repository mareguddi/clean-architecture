using The.Project.Domain.Models;
using The.Project.Domain.Repositories;
using The.Project.Domain.Services;

namespace TheFA.Project.Services
{
    public class WeatherForecastService : IWeatherForecastService
    {
        private readonly IWeatherForecastRepository _weatherForecastRepository;

        public WeatherForecastService(IWeatherForecastRepository weatherForecastRepository)
        {
            _weatherForecastRepository = weatherForecastRepository;
        }

        public Task<IEnumerable<WeatherForecastModel>> GetAsync()
        {
            //business logic goes here, might have to fetch data from multiple sources / services
            return _weatherForecastRepository.GetAsync();
        }
    }
}
using The.Project.Domain.Models;

namespace The.Project.Domain.Services
{
    public interface IWeatherForecastService
    {
        Task<IEnumerable<WeatherForecastModel>> GetAsync();
    }
}

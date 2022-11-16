using The.Project.Domain.Models;

namespace The.Project.Domain.Repositories
{
    public interface IWeatherForecastRepository
    {
        Task<IEnumerable<WeatherForecastModel>> GetAsync();
    }
}

using The.Project.Domain.Models;
using The.Project.Domain.Repositories;

namespace TheFA.Project.Data
{
    public class WeatherForecastRepository : IWeatherForecastRepository
    {
        private readonly AppDbContext _context;
        public WeatherForecastRepository(AppDbContext context)
        {
            _context = context;
        }

        public Task<IEnumerable<WeatherForecastModel>> GetAsync()
        {
            // todo:fetch data from DB
            //_context.WeatherForecast.AsQueryable().Take(10).ToList();

            var summaries = new[]
            {
                "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
            };

            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecastModel
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = summaries[Random.Shared.Next(summaries.Length)]
            }));
        }
    }
}

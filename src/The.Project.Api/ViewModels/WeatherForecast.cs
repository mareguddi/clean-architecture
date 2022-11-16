using The.Project.Domain.Models;

namespace The.Project.Api.ViewModels
{
    public class WeatherForecast
    {
        public DateTime Date { get; set; }

        public int TemperatureC { get; set; }

        public int TemperatureF;

        public string? Summary { get; set; }

        public static WeatherForecast FromModel(WeatherForecastModel model)
        {
            return new WeatherForecast()
            {
                Date = model.Date,
                TemperatureC = model.TemperatureC,
                Summary = model.Summary,
                TemperatureF = model.TemperatureF
            };
        }
    }
}
using Microsoft.EntityFrameworkCore;
using TheFA.Project.Data.Entity;

namespace TheFA.Project.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<WeatherForecastEntity> WeatherForecast { get; set; }
    }
}
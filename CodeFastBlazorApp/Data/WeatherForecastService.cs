using EntitieApps;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodeFastBlazorApp.Data
{
    public class WeatherForecastService
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        public Task<WeatherForecast[]> GetForecastAsync(DateTime startDate)
        {
            var rng = new Random();
            return Task.FromResult(Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = startDate.AddDays(index),
                TemperatureC = rng.Next(-20, 55),
                Summary = Summaries[rng.Next(Summaries.Length)]
            }).ToArray());
        }
        public IList<Student> GetStudents()
        {
            return new List<Student> { 
                new Student { Id = 1, FullName = "Shohag", DepartmentId = 1 },
                new Student { Id = 2, FullName = "Shohag", DepartmentId = 1 },
                new Student { Id = 3, FullName = "Shohag", DepartmentId = 1 },
                new Student { Id = 4, FullName = "Shohag", DepartmentId = 1 }
            };
        }
    }
}

using Infrastructure.Data;
using Infrastructure.EFModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Application.Api.Controllers
{
    
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private static int cnt = 0;

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly AppDemoContext _contextFactory;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, 
            AppDemoContext contextFactory)
        {
            _logger = logger;
            _contextFactory = contextFactory;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async  Task<IEnumerable<WeatherForecast>> Get()
        {
            cnt++;
            var record = new SampleTable() { Name_2 = $"MySampleRecord_{cnt}" };
            _contextFactory.Set<SampleTable>()
                .Add(record);
            await _contextFactory.SaveChangesAsync();

            cnt++;
            _contextFactory.Set<SecondTable>()
                .Add(
                    new SecondTable() { Name = $"Mystring_{cnt}", SampleTable = record }
                    );
            await _contextFactory.SaveChangesAsync();

            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
    }
}
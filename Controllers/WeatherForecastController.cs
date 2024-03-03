using Microsoft.AspNetCore.Mvc;

namespace WebApiTest.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController(ILogger<WeatherForecastController> logger) : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger = logger;

    [HttpGet]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 10).Select(index => new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
    }

    [HttpPost]
    [ProducesResponseType(200, Type = typeof(List<string>))]
    public IEnumerable<string> Post([FromBody]SummaryTest bodyInput)
    {
        var summary = bodyInput.Summary;
        return Summaries.Append(summary).ToList();
    }
}

public class SummaryTest
{
    public string Summary { get; }
}
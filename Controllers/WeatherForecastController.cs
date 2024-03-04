using Microsoft.AspNetCore.Mvc;
using WebApiTest.Helpers;

namespace WebApiTest.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController(ILogger<WeatherForecastController> logger) : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger = logger;

    [HttpGet]
    public IEnumerable<WeatherForecast> Get()
    {
        List<WeatherForecast> wfList = [];
        var i = 1;
        while (i <= 10)
        {
            var tempF = Random.Shared.Next(-40, 120);
            wfList.Add(new WeatherForecast
            {
                Date = DateOnly.FromDateTime(DateTime.Now.AddDays(i)),
                TemperatureF = tempF,
                Summary = Helper.TempSummary(tempF)
            });
            i++;
        }

        return wfList.ToArray();
    }

   /* [HttpPost]
    [ProducesResponseType(200, Type = typeof(List<string>))]
    public IEnumerable<string> Post([FromBody]SummaryTest bodyInput)
    {
        var summary = bodyInput.Summary;
        return Summaries.Append(summary).ToList();
    }*/
}
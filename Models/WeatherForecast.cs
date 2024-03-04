namespace WebApiTest;

public class WeatherForecast
{
    public DateOnly Date { get; set; }
    public int TemperatureF { get; set; }
    public int TemperatureC => Convert.ToInt32((TemperatureF - 32) / 1.8);
    public string? Summary { get; set; }
}
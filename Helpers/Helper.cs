using Microsoft.AspNetCore.Routing.Template;

namespace WebApiTest.Helpers;

public static class Helper
{
    public static string TempSummary(int tempF)
    {
        return tempF switch
        {
            < 0 => "Arctic",
            >= 0 and < 20 => "Bracing",
            >= 20 and < 32 => "Freezing",
            >= 32 and < 45 => "Chilly",
            >= 45 and < 55 => "Cool",
            >= 55 and < 65 => "Mild",
            >= 65 and < 75 => "Warm",
            >= 75 and < 90 => "Hot",
            >= 90 and < 100 => "Sweltering",
            >= 100 => "Scorching"
        };
    }
}
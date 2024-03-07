using Models;
using WeatherAPI;

namespace WeatherAPITest;

public class MockDatabaseService : IDatabaseService
{
    public string[] GetSummaries()
    {
        return new []
        {
            "Freezing", "Mild", "Hot"
        };
    }

    public void SaveForecasts(WeatherForecast[] forecasts)
    {
    }
}
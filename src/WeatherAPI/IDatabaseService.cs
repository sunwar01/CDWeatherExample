using Models;

namespace WeatherAPI;

public interface IDatabaseService
{
    string[] GetSummaries();
    void SaveForecasts(WeatherForecast[] forecasts);
}
using System.ComponentModel.Design;
using WeatherAPI;

namespace WeatherAPITest;

public class Tests
{
    [Test]
    public void TemperatureTest()
    {
        // Arrange
        var forecastService = new ForecastService(new MockDatabaseService());
        
        // Act
        var forecasts = forecastService.GetForecast();
        
        // Assert
        Assert.IsTrue(forecasts.All(f => f.TemperatureC >= -20), "There is a temperature (C) less than the minimum expected value.");
        Assert.IsTrue(forecasts.All(f => f.TemperatureC <= 55), "There is a temperature (C) greater than the maximum expected value.");
    }
}
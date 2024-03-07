using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Models;
using WeatherFrontend.Models;

namespace WeatherFrontend.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public async Task<IActionResult> Index()
    {
        var httpClient = new HttpClient();
        var result = await httpClient.GetAsync("http://weather-api:8080/weatherforecast");
        var forecasts = await result.Content.ReadFromJsonAsync<WeatherForecast[]>();
        return View(forecasts);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
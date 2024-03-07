using WeatherAPI;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseSwagger();
app.UseSwaggerUI();

app.MapGet("/weatherforecast", () =>
    {
        var forecastService = new ForecastService();
        return forecastService.GetForecast();
    })
    .WithName("GetWeatherForecast")
    .WithOpenApi();

app.Run();


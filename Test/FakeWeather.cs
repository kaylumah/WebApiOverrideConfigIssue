using Api;

namespace Test;

public class FakeWeather : IWeatherService
{
    public IEnumerable<WeatherForecast> GetWeather()
    {
        throw new NotImplementedException();
    }
}
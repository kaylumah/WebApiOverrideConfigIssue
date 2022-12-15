namespace Test;

public class UnitTest1
{
    [Fact]
    public async Task Test1()
    {
        var webApp = new WebApp();
        var client = webApp.CreateClient();
        var result = await client.GetAsync("WeatherForecast");
    }
}
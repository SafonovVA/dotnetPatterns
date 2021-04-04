using Observer.Classes;

namespace Observer
{
    static class Program
    {
        static void Main()
        {
            var weatherData = new WeatherData();
            var currentDisplay = new CurrentConditionsDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 45.6f);
            weatherData.SetMeasurements(75, 60, 43.2f);
            weatherData.SetMeasurements(78, 68, 49.8f);
        }
    }
}

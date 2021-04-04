using System;
using Observer.Interfaces;

namespace Observer.Classes
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private float temperature;
        private float humidity;
        private float pressure;
        private ISubject weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.registerObserver(this);
        }

        public void update(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            display();
        }

        public void display()
        {
            Console.WriteLine($"Current conditions: {temperature}, F degrees and {humidity} % {pressure}");
        }
    }
}
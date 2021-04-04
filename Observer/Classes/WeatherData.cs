using Observer.Interfaces;
using System.Collections.Generic;
using System;

namespace Observer.Classes
{
    public class WeatherData : ISubject 
    {
        private List<IObserver> observers = new List<IObserver>();
        private float temperature;
        private float humidity;
        private float pressure;
        public void registerObserver(IObserver o)
        {
            observers.Add(o);
        }
        public void removeObserver(IObserver o)
        {
            if (observers.IndexOf(o) >= 0)
            {
                observers.Remove(o);
            }
        }
        public void notifyObservers()
        {
            foreach (var observer in observers)
            {
                observer.update(temperature, humidity, pressure);
            }
        }

        public void measurementsChanged()
        {
            notifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            this.temperature = temperature;
            this.humidity = humidity;
            this.pressure = pressure;
            measurementsChanged();
        }
    }
}
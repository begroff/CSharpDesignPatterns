using System;
using System.Collections.Generic;
using Observer.Interfaces;

namespace Observer
{
    public class WeatherData : ISubject
    {
        private List<IObserver> observers;

        public float Temperature { get; set; }
        public float Humidity { get; set; }
        public float Pressure { get; set; }

        public WeatherData()
        {
            observers = new List<IObserver>();
        }

        public void RegisterObserver(IObserver observer)
        {
            observers.Add(observer);
        }

        public void RemoveObserver(IObserver observer)
        {
            if (observers.Contains(observer))
            {
                observers.Remove(observer);
            }
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update(this);
            }
        }

        public void MeasurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMeasurements(float temperature, float humidity, float pressure)
        {
            // Could make this an API call to weather service
            Temperature = temperature;
            Humidity = humidity;
            Pressure = pressure;

            MeasurementsChanged();
        }
    }
}
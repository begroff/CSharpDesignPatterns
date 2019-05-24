using System;
using Observer.Interfaces;

namespace Observer
{
    public class CurrentConditionsDisplay : IObserver, IDisplayElement
    {
        private double temperature;
        private double humidity;
        ISubject weatherData;

        public CurrentConditionsDisplay(ISubject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Update(WeatherData data)
        {
            this.temperature = data.Temperature;
            this.humidity = data.Humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine($"Current Conditions: {this.temperature}F degrees and {this.humidity}% humidity");
        }
    }
}
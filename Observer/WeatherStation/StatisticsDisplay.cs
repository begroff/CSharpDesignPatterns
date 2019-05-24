using System;
using Observer.Interfaces;

namespace Observer
{
    public class StatisticsDisplay : IObserver, IDisplayElement
    {
        private float maxTemperature = 0.0f;
        private float minTemperature = 200;
        private float temperatureSum = 0.0f;
        private int numberOfReadings;

        public StatisticsDisplay(ISubject weatherData)
        {
            weatherData.RegisterObserver(this);
        }

        public void Update(WeatherData weatherData)
        {
            float temperature = weatherData.Temperature;

            temperatureSum += temperature;
            numberOfReadings++;

            if (temperature > maxTemperature)
            {
                maxTemperature = temperature;
            }

            if (temperature < minTemperature)
            {
                minTemperature = temperature;
            }

            Display();
        }

        public void Display()
        {
            Console.WriteLine(
                $"Avg/Max/Min Temperature = {temperatureSum / numberOfReadings} / {maxTemperature} / {minTemperature}");
        }
    }
}
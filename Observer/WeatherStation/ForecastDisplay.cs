using System;
using Observer.Interfaces;

namespace Observer
{
    public class ForecastDisplay : IObserver, IDisplayElement
    {
        private float currentPressure = 29.92f;
        private float lastPressure;

        public ForecastDisplay(ISubject weatherData)
        {
            weatherData.RegisterObserver(this);
        }

        public void Update(WeatherData weatherData)
        {
            lastPressure = currentPressure;
            currentPressure = weatherData.Pressure;

            Display();
        }

        public void Display()
        {
            Console.Write("Forecast: ");

            if (currentPressure > lastPressure)
                Console.WriteLine("Improving weather on the way!");
            else if (currentPressure == lastPressure)
                Console.WriteLine("More of the same");
            else if (currentPressure < lastPressure)
                Console.WriteLine("Watch out for cooler, rainy weather");
        }
    }
}
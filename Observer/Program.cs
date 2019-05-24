using System;

namespace Observer
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();

            CurrentConditionsDisplay currentConditions =
                new CurrentConditionsDisplay(weatherData);

            StatisticsDisplay statsDisplay = new StatisticsDisplay(weatherData);
            ForecastDisplay forecastDisplay = new ForecastDisplay(weatherData);

            weatherData.SetMeasurements(80, 65, 30.4F);
            weatherData.SetMeasurements(82, 70, 29.2F);
            weatherData.SetMeasurements(78, 90, 29.2F);
        }
    }
}

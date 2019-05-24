using System;

namespace Observer.Interfaces
{
    public interface IObserver
    {
        void Update(WeatherData data);
    }
}
using System.Collections.Generic;
using ObserverDesignPattern.WeatherStation.Host.Observers;
using ObserverDesignPattern.WeatherStation.Host.Subject;

namespace ObserverDesignPattern.WeatherStation.Host.Data
{
    public class WeatherData : IWeatherSubject
    {
        private float _temperature;
        private float _humidity;
        private float _pressure;
        private readonly List<IWeatherObserver> _observers;

        public WeatherData()
        {
            _observers = new List<IWeatherObserver>();
        }
        public void RegisterObserver(IWeatherObserver weatherObserver)
        {
            _observers.Add(weatherObserver);
        }

        public void RemoveObserver(IWeatherObserver weatherObserver)
        {
            int index = _observers.IndexOf(weatherObserver);
            if (index >= 0)
            {
                _observers.Remove(weatherObserver);
            }
            else
            {
                //Do nothing
            }
        }

        public void NotifyObservers()
        {
            for (int i = 0; i < _observers.Count; i++)
            {
                IWeatherObserver weatherObserver = _observers[i];
                weatherObserver.Update(_temperature, _humidity, _pressure);
            }
        }

        public void MesurementsChanged()
        {
            NotifyObservers();
        }

        public void SetMesurements(float temperature, float humidity, float pressure)
        {
            _temperature = temperature;
            _humidity = humidity;
            _pressure = pressure;

            MesurementsChanged();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using ObserverDesignPattern.WeatherStation.Host.Observers;
using ObserverDesignPattern.WeatherStation.Host.Subject;

namespace ObserverDesignPattern.WeatherStation.Host.Display
{
    public class CurrentConditionsDisplay : IWeatherObserver, IDisplayElement
    {
        private float _temperature;
        private float _humidity;
        private IWeatherSubject _weatherData;

        public CurrentConditionsDisplay(IWeatherSubject weatherData)
        {
            _weatherData = weatherData;
            _weatherData.RegisterObserver(this);
        }
        public void Update(float tempt, float humidity, float pressure)
        {
            _temperature = tempt;
            _humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Güncel Durum : " + _temperature + " C / " + _humidity );
        }
    }
}

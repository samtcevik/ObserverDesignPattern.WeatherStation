using ObserverDesignPattern.WeatherStation.Host.Display;
using System;
using ObserverDesignPattern.WeatherStation.Host.Data;

namespace ObserverDesignPattern.WeatherStation.UI
{
    class Program
    {
        static void Main(string[] args)
        {
            WeatherData weatherData = new WeatherData();
            CurrentConditionsDisplay currentDisplay = new CurrentConditionsDisplay(weatherData);

            weatherData.SetMesurements(80, 65, 30.4f);
            weatherData.SetMesurements(82, 70, 29.2f);
            weatherData.SetMesurements(78, 90, 29.2f);
        }

    }
}

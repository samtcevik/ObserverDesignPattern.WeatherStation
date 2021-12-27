using ObserverDesignPattern.WeatherStation.Host.Observers;

namespace ObserverDesignPattern.WeatherStation.Host.Subject
{
    public interface IWeatherSubject
    {
        public void RegisterObserver(IWeatherObserver weatherObserver);
        public void RemoveObserver(IWeatherObserver weatherObserver);
        public void NotifyObservers();
    }
}

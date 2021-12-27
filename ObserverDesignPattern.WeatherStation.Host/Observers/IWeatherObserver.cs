namespace ObserverDesignPattern.WeatherStation.Host.Observers
{
    public interface IWeatherObserver
    {
        public void Update(float tempt, float humidity, float pressure);
    }
}

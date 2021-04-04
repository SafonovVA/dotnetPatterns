namespace Observer.Interfaces
{
    public interface IObserver
    {
        public void update(float temperature, float humidity, float pressure);
    }
}
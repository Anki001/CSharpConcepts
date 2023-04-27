using Learning.DataStore.Repositories;

namespace Learning.DataStore.Interfaces
{
    public interface IUnitOfWork
    {
        public WeatherForecastRepository WeatherForecastRepository { get; }
    }
}

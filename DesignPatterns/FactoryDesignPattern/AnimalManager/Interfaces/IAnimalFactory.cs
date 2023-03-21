namespace FactoryDesignPattern.AnimalManager.Interfaces
{
    internal interface IAnimalFactory
    {
        TResponse ProcessRequest<TRequest, TResponse>(TRequest request)
            where TRequest : class
            where TResponse : class;
    }
}

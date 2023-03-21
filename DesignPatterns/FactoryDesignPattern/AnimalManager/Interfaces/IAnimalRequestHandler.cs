namespace FactoryDesignPattern.AnimalManager.Interfaces
{
    internal interface IAnimalRequestHandler<in TRequest, TResponse>
        where TRequest: class
        where TResponse: class
    {
        TResponse Speak(TRequest request);
    }
}

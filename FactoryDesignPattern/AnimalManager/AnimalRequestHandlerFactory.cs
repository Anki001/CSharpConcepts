using FactoryDesignPattern.AnimalManager.Interfaces;

namespace FactoryDesignPattern.AnimalManager
{
    internal class AnimalRequestHandlerFactory : IAnimalFactory
    {
        private readonly IServiceProvider _serviceProvider;

        public AnimalRequestHandlerFactory(IServiceProvider serviceProvider)
        {
            _serviceProvider = serviceProvider;
        }

        public TResponse ProcessRequest<TRequest, TResponse>(TRequest request)
            where TRequest : class
            where TResponse : class
        {
            var handler = (IAnimalRequestHandler<TRequest, TResponse>)_serviceProvider.GetService(typeof(IAnimalRequestHandler<TRequest, TResponse>));
            
            if (handler == null)
            {
                throw new NotImplementedException($"No handler register for type: {typeof(TRequest).FullName}");                
            }

            return handler.Speak(request);
        }
    }
}

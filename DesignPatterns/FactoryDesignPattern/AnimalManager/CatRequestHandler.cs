using FactoryDesignPattern.AnimalManager.Interfaces;
using FactoryDesignPattern.Messages.Request;
using FactoryDesignPattern.Messages.Response;

namespace FactoryDesignPattern.AnimalManager
{
    internal class CatRequestHandler : IAnimalRequestHandler<CatRequest, AnimalResponse>
    {
        public AnimalResponse Speak(CatRequest request)
        {
            return new AnimalResponse
            {
                Sound = "Meue!"
            };
        }
    }
}

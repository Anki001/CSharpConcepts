using FactoryDesignPattern.AnimalManager.Interfaces;
using FactoryDesignPattern.Messages.Request;
using FactoryDesignPattern.Messages.Response;

namespace FactoryDesignPattern.AnimalManager
{
    internal class DogRequestHandler : IAnimalRequestHandler<DogRequest, AnimalResponse>
    {
        public AnimalResponse Speak(DogRequest request)
        {
            return new AnimalResponse
            {
                Sound = "Woof!"
            };
        }
    }
}

using FactoryDesignPattern.Concrete;
using FactoryDesignPattern.Factory.Interfaces;
using FactoryDesignPattern.Interfaces;

namespace FactoryDesignPattern.Factory
{
    internal class DogFactory : IAnimalFactory
    {
        public IAnimal CreateAnimal()
        {
            return new Dog();
        }
    }
}

using FactoryDesignPattern.Concrete;
using FactoryDesignPattern.Factory.Interfaces;
using FactoryDesignPattern.Interfaces;

namespace FactoryDesignPattern.Factory
{
    internal class CatFactory : IAnimalFactory
    {
        public IAnimal CreateAnimal()
        {
            return new Cat();
        }
    }
}

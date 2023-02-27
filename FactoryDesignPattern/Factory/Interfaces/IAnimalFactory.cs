using FactoryDesignPattern.Interfaces;

namespace FactoryDesignPattern.Factory.Interfaces
{
    internal interface IAnimalFactory
    {
        IAnimal CreateAnimal();
    }
}

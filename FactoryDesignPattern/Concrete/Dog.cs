using FactoryDesignPattern.Interfaces;

namespace FactoryDesignPattern.Concrete
{
    internal class Dog : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Woof!");
        }
    }
}

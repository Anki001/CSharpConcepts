using FactoryDesignPattern.Interfaces;

namespace FactoryDesignPattern.Concrete
{
    internal class Cat : IAnimal
    {
        public void Speak()
        {
            Console.WriteLine("Meow!");
        }
    }
}

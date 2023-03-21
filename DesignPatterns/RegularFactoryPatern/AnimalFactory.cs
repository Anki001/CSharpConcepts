namespace RegularFactoryPattern
{
    internal abstract class AnimalFactory : IAnimalFactory
    {
        public abstract IAnimal ReturnAnimal();
    }

    internal class DogFactory : AnimalFactory
    {
        public override IAnimal ReturnAnimal()
        {
            return new Dog();
        }
    }
    internal class CatFactory : AnimalFactory
    {
        public override IAnimal ReturnAnimal()
        { 
            return new Cat();
        }
    }
}

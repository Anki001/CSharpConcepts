// See https://aka.ms/new-console-template for more information

using RegularFactoryPattern;

IAnimalFactory _factory;

_factory = new DogFactory();
IAnimal _dog = _factory.ReturnAnimal();
Console.WriteLine($"Dog sound like {_dog.Sound()}");

_factory = new CatFactory();
IAnimal _cat = _factory.ReturnAnimal();
Console.WriteLine($"Cat sound like {_cat.Sound()}");


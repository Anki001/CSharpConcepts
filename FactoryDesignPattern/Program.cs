// See https://aka.ms/new-console-template for more information
using FactoryDesignPattern.Factory;
using FactoryDesignPattern.Factory.Interfaces;
using FactoryDesignPattern.Interfaces;

IAnimalFactory dogFactory = new DogFactory();
IAnimal dog = dogFactory.CreateAnimal();
dog.Speak();

IAnimalFactory catFactory = new CatFactory();
IAnimal cat = catFactory.CreateAnimal();
cat.Speak();

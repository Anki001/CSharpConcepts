// See https://aka.ms/new-console-template for more information
using FactoryDesignPattern.AnimalManager.Interfaces;
using FactoryDesignPattern.Configuration;
using FactoryDesignPattern.Messages.Request;
using FactoryDesignPattern.Messages.Response;

internal class Program
{
    private static void Main(string[] args)
    {
        ConfigureServices.Configure();

        IAnimalFactory _animalFactory = ConfigureServices.GetService<IAnimalFactory>();

        var dog = _animalFactory.ProcessRequest<DogRequest, AnimalResponse>(new DogRequest());

        Console.WriteLine($"Dog Sound like {dog.Sound}");

        var cat = _animalFactory.ProcessRequest<CatRequest, AnimalResponse>(new CatRequest());

        Console.WriteLine($"Cat Sound like {cat.Sound}");
    }
}



// How Dog speaks

// How cat speaks

// See https://aka.ms/new-console-template for more information

using ISerializableExample;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using static System.Net.Mime.MediaTypeNames;

internal class Program
{
    private static void Main(string[] args)
    {
        // Create an instance of the type and serialize it.
        Person person = new Person
        {
            FirstName = "Ankush",
            LastName = "Gawande",
            Age = 30,
            Address = "Pune"
        };

        // This is the name of the file holding the data. You can use any file extension you like.
        string fileName = @"c:\dataStuff.myData";

        // Use a BinaryFormatter or SoapFormatter.
        IFormatter formatter = new BinaryFormatter();
        //IFormatter formatter = new SoapFormatter();

        SerializeItem<Person>(fileName, formatter, person); // Serialize an instance of the class.

        DeserializeItem(fileName, formatter); // Deserialize the instance.
        Console.WriteLine("Done");
        Console.ReadLine();
    }
    private static void SerializeItem<T>(string fileName, IFormatter formatter, T obj)
    {
        FileStream s = new FileStream(fileName, FileMode.Create);
        formatter.Serialize(s, obj);
        s.Close();
    }

    private static void DeserializeItem(string fileName, IFormatter formatter)
    {
        FileStream s = new FileStream(fileName, FileMode.Open);
        Person t = (Person)formatter.Deserialize(s);
        Console.WriteLine(t.FirstName);
    }
}
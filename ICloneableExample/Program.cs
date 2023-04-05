// See https://aka.ms/new-console-template for more information
using ICloneableExample;

var person = new Person
{
    Name = "Foo",
    Age = 1
};

Console.WriteLine("\nDetails of person:");
Console.WriteLine($"Name: {person.Name}, Age: {person.Age}");

var person1 = (Person)person.Clone();

Console.WriteLine("\nDetails of person 1:");
Console.WriteLine($"Name: {person1.Name}, Age: {person1.Age}");
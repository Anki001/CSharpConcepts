// See https://aka.ms/new-console-template for more information
using CustomGenericClass;

MyList<int> numbers = new MyList<int>();
numbers.Add(1);
numbers.Add(2);
numbers.Add(3);

Console.WriteLine(numbers.Get(index: 2));

MyList<string> names = new MyList<string>();
names.Add("Ankush");
names.Add("Rohini");
names.Add("Arush");

Console.WriteLine(names.Get(index: 1));


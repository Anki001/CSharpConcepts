// See https://aka.ms/new-console-template for more information

#region [Example of Predicate - Find even number]

List<int> numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Predicate<int> isEven = n => n % 2 == 0;

List<int> evenNumbers = numbers.FindAll(isEven);

Console.WriteLine("Event numbers are:");

foreach (var item in evenNumbers)
{
    Console.WriteLine(item);
}

#endregion

#region [Example of Function - List is having all even number]

List<int> numbers1 = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
Func<int, bool> isEven1 = x => x % 2 == 0;

var AllEven = numbers1.All(isEven1);

Console.WriteLine($"All numbers are even: {AllEven}");

#endregion


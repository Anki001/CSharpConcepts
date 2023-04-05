// See https://aka.ms/new-console-template for more information

#region [Example of Predicate - Find even number]

using PredicateAndFunction;

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

Func<int, bool> isEven1 = x => x % 2 == 0;

var AllEven = numbers.All(isEven1);

Console.WriteLine($"All numbers are even: {AllEven}");

#endregion

#region [Custom Func<T, T, TResult> - Math operations]
var sum = MathOperations.MathOps(2, 4, (x, y) => x + y);
Console.WriteLine($"Sum is : {sum}");

var sub = MathOperations.MathOps(8, 4, (x, y) => x - y);
Console.WriteLine($"Substraction is: {sub}");

var multiply = MathOperations.MathOps(2, 4, (x, y) => x * y);
Console.WriteLine($"Multiply is: {multiply}");

#endregion

#region [Custom Predicate<T> - List operations]

var evenNums = ListOperations.ListOps(numbers, x => x % 2 == 0);

Console.WriteLine("Custom Predicate - Even numbers are:");

foreach (var num in evenNums)
{
    Console.WriteLine(num);
}

#endregion
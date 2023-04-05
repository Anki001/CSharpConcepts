// See https://aka.ms/new-console-template for more information

using LinqSamples;

List<int> numbers = new List<int> { 10, 6, 2, 8, 4, 9, 1, 7, 3, 5 };

LinqOperations.PrintTopNNumbers(numbers, 5);

Console.WriteLine("");

List<Employee> employees = new List<Employee> {
    new Employee{
        FirstName = "Ankush",
        LastName = "Gawande",
        Department = "IT",
        Salary = 4700
    },
    new Employee{
        FirstName = "Abhijit",
        LastName = "Dhoble",
        Department = "IT",
        Salary = 5000
    },
    new Employee{
        FirstName = "Wei",
        LastName = "Ping",
        Department = "IT",
        Salary = 3000
    },
};

LinqOperations.PrintTopNEmployeeBasedOnSalary(employees, 2);

Console.WriteLine("");

LinqOperations.PrintEmployeeNthHighestSalary(employees, 2);

Console.WriteLine("");

List<int> numbers1 = new List<int> { 10, 6, 2, 8, 1, 7, 3, 5 };

LinqOperations.PrintMissingNumbers(numbers1);

#region [Predicate to find even number from list]

var evenNumbers = numbers1.FindAll(x => x % 2 == 0);

Console.WriteLine("Even numbers are:");

foreach (var even in evenNumbers)
{
    Console.WriteLine(even);
}

#endregion

#region [Sort List - split the strings by pipe (|) and then use the second element (index 1) to order the collection]

List<string> inputList = new List<string> { "rajesh|51|32|asd", "nitin|71|27|asd", "test|11|30|asd" };
StringOperations.SortList(inputList);

#endregion

#region[Sort array - split the strings by pipe (|) and then use the second element (index 1) to order the collection]

string[] inputArray = { "rajesh|51|32|asd", "nitin|71|27|asd", "test|11|30|asd" };
var output = inputArray.OrderByDescending(x => x.Split('|')[1]).ToArray();

#endregion
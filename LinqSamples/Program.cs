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
// See https://aka.ms/new-console-template for more information

using UsingStatement;

var a = new Employee();
a.Name = "A";
a.Age = 1;

Console.WriteLine($"Age of {a.Name} is {a.Age} years.");
a.Dispose();

using (var emp = new Employee())
{
    emp.Name = "B";
    emp.Salary = 2;

    Console.WriteLine($"Salary of employe {a.Name} is {a.Salary} years.");
}

//Both calling the Dispose method on an object and disposing the object using the using statement accomplish the same thing,
//which is to release any unmanaged resources held by the object.

//The main difference between calling the Dispose method directly and using the using statement is that the using statement provides
//a more convenient and reliable way to ensure that the Dispose method is called.

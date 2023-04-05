namespace LinqSamples
{
    public class LinqOperations
    {
        internal static void PrintTopNNumbers(IEnumerable<int> numbers, int n)
        {
            var topNRecords = numbers
                .OrderByDescending(x => x)
                .Take(n);

            Console.WriteLine($"Top {n} records are:");

            foreach (var item in topNRecords)
            {
                Console.WriteLine(item);
            }
        }

        internal static void PrintTopNEmployeeBasedOnSalary(IEnumerable<Employee> employees, int n)
        {
            var topNEmployeeSalary = employees
                .OrderByDescending(x => x.Salary)
                .Take(n);

            Console.WriteLine($"Top {n} records are:");

            foreach (var item in topNEmployeeSalary)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");
            }
        }

        internal static void PrintEmployeeNthHighestSalary(IEnumerable<Employee> employees, int n)
        {
            var employee = employees
                .OrderByDescending(x => x.Salary)
                .Distinct()
                .Skip(n-1)
                .FirstOrDefault();

            Console.WriteLine($"{employee.FirstName} {employee.LastName} have the {n} highest salary:");
            
        }

        internal static void PrintMissingNumbers(List<int> numbers)
        {
            var missingNumbers = Enumerable
                .Range(numbers.Min(), numbers.Count + 1)
                .Except(numbers)
                .ToList();

            Console.WriteLine("Missing numbers are:");

            foreach (var item in missingNumbers)
            {
                Console.WriteLine($"{item}");
            }
        }
    }
}

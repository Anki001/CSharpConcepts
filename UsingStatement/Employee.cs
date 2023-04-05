namespace UsingStatement
{
    internal class Employee: IDisposable
    {
        public string? Name { get; set; }
        public string? Department { get; set; }
        public int Age { get; set; }
        public double Salary { get; set; }

        public void Dispose()
        {
            // Write logic to dispose the unmanaged resorces used in Employee class
        }
    }
}

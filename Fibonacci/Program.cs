// See https://aka.ms/new-console-template for more information
using System.ComponentModel.Design;

int numTerms = 10;
int[] fib = new int[numTerms];

for (int i = 0; i < numTerms; i++)
{
    if (i < 2)
    {
        fib[i] = i;
    }
    else
    {
        fib[i] = fib[i - 1] + fib[i - 2];
    }
}


Console.WriteLine("Fibonacci Sequence:");
for (int i = 0; i < numTerms; i++)
{
    Console.WriteLine($"{fib[i]} ");
}

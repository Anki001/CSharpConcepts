// See https://aka.ms/new-console-template for more information

static void FibonacciSeries(int numTerms)
{
    // Create a new array to hold the numbers of fibonacci series
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

    for (int i = 0; i < numTerms; i++)
    {
        Console.WriteLine($"{fib[i]} ");
    }
}


int numTerms = 10;

Console.WriteLine("Fibonacci Sequence:");
FibonacciSeries(numTerms);

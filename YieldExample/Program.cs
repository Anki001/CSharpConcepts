// See https://aka.ms/new-console-template for more information
using System.Runtime.CompilerServices;

static IEnumerable<int> GetNumbers()
{
    yield return 1;
    yield return 2;
    yield return 3;
    yield return 4;
    yield return 5;
}

static IEnumerable<double> GetPower(double number, int power)
{
    double result = number;
    while (true)
    {
        yield return result;
        result *= power;
    }
}

//foreach (var number in GetNumbers())
//{
//    Console.WriteLine(number);
//}


double number1 = 2; // change this to the number you want to raise to the power of 8
int powerToCalculate = 2;

foreach (double power in GetPower(number1, powerToCalculate))
{
    Console.WriteLine(power);
    if (power > 1000000) // stop after the power exceeds 1 million
    {
        break;
    }
}
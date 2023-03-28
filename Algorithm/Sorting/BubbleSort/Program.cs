// See https://aka.ms/new-console-template for more information

int[] input = new int[] { 4, 2, 1, 5, 3 };

for (int i = 0; i < input.Length - 1; i++)
{
    for (int j = i + 1; j < input.Length; j++)
    {
        if (input[i] > input[j])
        { 
            var a = input[i];
            input[i] = input[j];
            input[j] = a;
        }
    }
}

foreach (var item in input)
{
    Console.WriteLine(item);
}

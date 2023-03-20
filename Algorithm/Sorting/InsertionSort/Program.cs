// See https://aka.ms/new-console-template for more information
int[] unSortedArray = new int[] { 4, 2, 1, 5, 3 };

Console.WriteLine("Unsorted List:");
foreach (var item in unSortedArray)
{
    Console.Write($"{item} ");
}

for (int i = 1; i < unSortedArray.Length; i++)
{
    var key = unSortedArray[i];
    var j = i - 1;

    while (j >= 0 && unSortedArray[j] > key)
    {
        unSortedArray[j + 1] = unSortedArray[j];
        j--;
    }
    unSortedArray[j + 1] = key;
}

Console.WriteLine("\nSorted List:");

foreach (var item in unSortedArray)
{
    Console.Write($"{item} ");
}


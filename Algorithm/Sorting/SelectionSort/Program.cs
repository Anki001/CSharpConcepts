// See https://aka.ms/new-console-template for more information
int[] unSortedArray = new int[] { 4, 2, 1, 5, 3 };

Console.WriteLine("Unsorted List:");
foreach (var item in unSortedArray)
{
    Console.Write($"{item} ");
}

// One by one move boundry of unsorted subarray
for (int i = 0; i < unSortedArray.Length - 1; i++)
{
    var minIndex = i;
    // Find the minimum element in unsorted array
    for (int j = i + 1; j < unSortedArray.Length; j++)
    {
        if (unSortedArray[j] < unSortedArray[minIndex])
        {
            minIndex = j;
        }
    }

    // Swap the found minimum element with the first element
    var temp = unSortedArray[minIndex];
    unSortedArray[minIndex] = unSortedArray[i];
    unSortedArray[i] = temp;
}

Console.WriteLine("\nSorted List:");

foreach (var item in unSortedArray)
{
    Console.Write($"{item} ");
}
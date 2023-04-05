// See https://aka.ms/new-console-template for more information

static int[] FindMultipleMissingNumbers(int[] numbers)
{
    // calculate the minimum and maximum values in the array
    int min = numbers.Min();
    int max = numbers.Max();

    // create a new array to hold the missing numbers
    int[] missingNumbers = new int[max - min - (numbers.Length - 1)];

    int j = 0;

    // loop through the range of numbers between the minimum and maximum values
    for (int i = min; i < max; i++)
    {
        // if the current number is not in the input array, add it to the missing numbers array
        if (!numbers.Contains(i))
        {
            missingNumbers[j++] = i;
        }
    }

    return missingNumbers;
}

static int FindMissingNumber(int[] arr)
{
    int n = arr.Length + 1;
    // calculate total sum of the array elements including missing numbers
    int totalSum = n * (n + 1) / 2;

    int sum = 0;

    // calculate actual sum of array numbers
    for (int i = 0; i < arr.Length; i++)
    {
        sum += arr[i];
    }
    return totalSum - sum;

}

int[] arr = { 1, 4, 5, 3, 7, 8, 2 };

int missing = FindMissingNumber(arr);
Console.WriteLine("Missing Number is: " + missing);

int[] arr1 = { 1, 4, 5, 7, 8, 2 };

int[] missingNumbers = FindMultipleMissingNumbers(arr1);
Console.WriteLine("Missing Number is: " + string.Join(',',missingNumbers));

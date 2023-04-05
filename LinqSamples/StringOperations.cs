namespace LinqSamples
{
    public class StringOperations
    {
        public static void SortList(List<string> inputArray)
        {
            var outputArray = inputArray.OrderByDescending(x => x.Split('|')[1]);

            foreach ( var output in outputArray)
            {
                Console.WriteLine(output.ToString());
            }
        }
    }
}

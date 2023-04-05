namespace PredicateAndFunction
{
    public class ListOperations
    {
        public static List<int> ListOps(List<int> numbers, Predicate<int> predicate)
        {
            List<int> result = new List<int>();

            foreach (var num in numbers)
            {
                if (predicate(num))
                    result.Add(num);
            }
            return result;
        }
    }
}

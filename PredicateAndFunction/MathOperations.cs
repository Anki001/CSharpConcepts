namespace PredicateAndFunction
{
    public class MathOperations
    {
        public static int MathOps(int a, int b, Func<int, int, int> ops)
        {
            return ops(a, b);
        }
    }
}

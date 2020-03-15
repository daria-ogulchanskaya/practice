namespace Practice
{
    public static class Factorial
    {
        public static int Recursion(int n)
        {
            if (n == 0 || n == 1)
                return 1;

            return n * Recursion(n - 1);
        }

        public static int Cycle(int n)
        {
            var result = 1;

            if (n > 1)
            {
                for (int i = 2; i <= n; i++)
                    result *= i;
            }

            return result;
        }
    }
}

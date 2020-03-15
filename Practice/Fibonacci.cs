namespace Practice
{
    public static class Fibonacci
    {
        public static int Cycle(int n)
        {
            var result = new int[n];
            result[0] = 0;

            if (n > 1)
                result[1] = 1;

            if (n > 2)
            {
                for (int i = 2; i < n; i++)
                    result[i] = result[i - 1] + result[i - 2];
            }

            return result[n - 1];
        }

        public static int Recursion(int n)
        {
            if (n == 0)
                return 0;
            if (n == 1)
                return 1;

            return Recursion(n - 1) + Recursion(n - 2);
        }
    }
}

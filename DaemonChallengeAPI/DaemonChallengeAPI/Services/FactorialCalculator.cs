namespace DaemonChallengeAPI.Services
{
    public static class FactorialCalculator
    {
        public static ulong Calculate(int number)
        {
            ulong factorial = 1;
            for (int i = number; i > 1; i--)
            {
                factorial = factorial * (ulong) i;
            }
            return factorial;
        }
    }
}

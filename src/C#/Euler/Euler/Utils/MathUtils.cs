namespace Euler.Utils
{
    public static class MathUtils
    {
        public static bool IsPrime(int number)
        {
            for (var i = 2; i < number; i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
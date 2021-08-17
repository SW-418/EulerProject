using System;
using System.Collections.Generic;
using System.Linq;

namespace Euler.Question7
{
    public static class BigPrimeNumber
    {
        //By listing the first six prime numbers: 2, 3, 5, 7, 11, and 13, we can see that the 6th prime is 13.
        //What is the 10 001st prime number?

        public static int FindNthPrime(int n)
        {
            // We try to divide by known and discovered prime numbers 
            var existingPrimes = new List<int> { 2, 3, 5, 7, 11, 13};
            for (var i = existingPrimes[^1] + 1; existingPrimes.Count < 10001; i++)
            {
                var wasDivisible = false;
                foreach (var number in existingPrimes)
                {
                    if (i % number == 0)
                    {
                        wasDivisible = true;
                    }
                }

                if (!wasDivisible)
                {
                    Console.WriteLine($"Prime found: {i} - Count: {existingPrimes.Count}");
                    existingPrimes.Add(i);
                }
            }
            return existingPrimes.Last();
        }
    }
}
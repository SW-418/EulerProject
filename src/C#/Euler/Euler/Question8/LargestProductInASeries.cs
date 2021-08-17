using System;

namespace Euler.Question8
{
    public static class LargestProductInASeries
    {
        public static int FindLargestProduct(string input, int windowSize)
        {
            var largestProduct = 0;
            var previousWindow = 0;
            for (var i = 0; i < input.Length - windowSize; i++)
            {
                if (largestProduct == 0)
                {
                    var initialWindow = CalculateInitialWindow(input, windowSize);
                    largestProduct = initialWindow;
                    previousWindow = initialWindow;
                }
                else
                {
                    var newWindow = previousWindow / int.Parse(input[i - 1].ToString()); //Remove first value
                    newWindow += newWindow * int.Parse(input[i + windowSize].ToString()); // Add last value
                    Console.WriteLine($"newWindow: {input.Substring(i, windowSize)}");
                    if (newWindow > largestProduct)
                    {
                        largestProduct = newWindow;
                    }
                    previousWindow = newWindow;
                }
            }

            return largestProduct;
        }

        private static int CalculateInitialWindow(string input, int windowSize)
        {
            var initialCount = 1;
            for (var i = 0; i < windowSize; i++)
            {
                initialCount += initialCount * int.Parse(input[i].ToString());
            }

            return initialCount;
        }
    }
}
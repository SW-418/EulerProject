using System;

namespace Euler.Question8
{
    public static class LargestProductInASeries
    {
        public static float FindLargestProduct(string input, int windowSize)
        {
            var largestProduct = 0.0f;
            var previousWindow = 0;

            for (var i = 0; i < (input.Length - windowSize) + 1; i++)
            {
                var subWindow = input.Substring(i, windowSize);
                var total = 1.0f;
                foreach(var letter in subWindow)
                {
                    total *= Int64.Parse(letter.ToString());
                }

                if (total > largestProduct)
                {
                    largestProduct = total;
                }
                Console.WriteLine($"Count: {i} - Subwindow: {subWindow} - Total: {total}");
            }

            Console.WriteLine($"Largest Product: {largestProduct}");
            return largestProduct;
        }
    }
}
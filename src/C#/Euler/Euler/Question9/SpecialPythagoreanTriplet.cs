using System;
using System.Collections.Generic;

namespace Euler.Question9
{
    public class SpecialPythagoreanTriplet
    {
        public static int CalculateSpecialTriplet(int input)
        {
            var maxValue = input;
            var dict = new Dictionary<int, int>();
            var specialValue = 0;

            for (var i = 1; i < maxValue; i++)
            {
                var squared = i * i;
                dict.Add(squared, i);
            }

            foreach (var data in dict)
            {
                foreach (var data2 in dict)
                {
                    if (data.Key != data2.Key)
                    {
                        var expected = data.Key + data2.Key;
                        if (dict.TryGetValue(expected, out var result))
                        {
                            var res = data.Value + data2.Value + result;

                            if (res == 1000)
                            {
                                Console.WriteLine($"Result: {data.Value}-{data2.Value}-{result}");
                            }
                        }
                    }
                }
            }
            return 1;
        }
    }
}

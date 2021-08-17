
using System.Collections.Generic;
using System.Text;

namespace Euler
{
    public class Playground
    {
        private static Dictionary<char, int> alphabet = new Dictionary<char, int>
        {
            {'a', 1},
            {'b', 2},
            {'c', 3},
            {'d', 4},
            {'e', 5},
            {'f', 6},
            {'g', 7},
            {'h', 8},
            {'i', 9},
            {'j', 10},
            {'k', 11},
            {'l', 12},
            {'m', 13},
            {'n', 14},
            {'o', 15},
            {'p', 16},
            {'q', 17},
            {'r', 18},
            {'s', 19},
            {'t', 20},
            {'u', 21},
            {'v', 22},
            {'w', 23},
            {'x', 24},
            {'y', 25},
            {'z', 26}
        };

        public IList<IList<string>> GroupAnagrams(string[] strs)
        {
            var list = new List<IList<string>>();
            var dict = new Dictionary<string, List<string>>();

            foreach (var word in strs)
            {
                var key = CreateKey(word);
                if (dict.TryGetValue(key, out var wordList))
                {
                    wordList.Add(word);
                }
                else
                {
                    dict.Add(key, new List<string>{ word });
                }
            }

            foreach (var data in dict)
            {
                list.Add(data.Value);
            }
            
            return list;
        }

        private string CreateKey(string word)
        {
            var value = 0;
            var highestValue = 0;
            var count = new int[26];

            foreach (var letter in word)
            {
                alphabet.TryGetValue(letter, out var letterValue);
                count[letterValue] += 1;
                // if (letterValue > highestValue)
                // {
                //     highestValue = letterValue;
                // }
                // value += letterValue;
            }

            return count.ToString();
        }
    }
}
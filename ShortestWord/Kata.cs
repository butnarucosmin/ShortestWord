using System.Collections.Generic;
using System.Linq;

namespace ShortestWord
{
    public class Kata
    {
        public static int FindShort(string s)
        {
            var results = new List<int>();
            var words = s.Split(' ');

            foreach (var word in words)
            {
                results.Add(word.Length);
            }

            return results.Min();
        }
    }
}
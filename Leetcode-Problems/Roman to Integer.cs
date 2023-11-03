using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Leetcode_Problems
{
    /*
     * Constraints:
     * 1. 1 <= s.length <= 15
     * s contains only the characters I, V, X, L, C, D, M
     * It is guaranteed t hat s is a valid roman numeral in the range (1, 3999)
     *
     * Hints:
     * Symbol   Value
     * I        1
     * V        5
     * X        10
     * L        50
     * C        100
     * D        500
     * M        1000
     */
    internal class Roman_to_Integer
    {
        private readonly Dictionary<char, int> _m =
            new()
            {
                { 'I', 1 },
                { 'V', 5 },
                { 'X', 10 },
                { 'L', 50 },
                { 'C', 100 },
                { 'D', 500 },
                { 'M', 1000 }
            };

        public int RomanToInt(string s)
        {
            int t = 0,
                n,
                n1;

            for (int i = 0; i < s.Length; i++)
            {
                n = _m[s[i]];

                if (i != s.Length - 1)
                {
                    n1 = _m[s[i + 1]];

                    if (n1 > n)
                    {
                        n = n1 - n;

                        i++;
                    }
                }

                t += n;
            }

            return t;
        }
    }
}

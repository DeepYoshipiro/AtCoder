using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC137C
    {
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());

            var appearedS = new Dictionary<string, long>();
            for (int i = 0; i < N; i++)
            {
                var s = ReadLine().ToCharArray();
                var curS = new string(s.OrderBy(n => n).ToArray());

                if (appearedS.ContainsKey(curS))
                {
                    appearedS[curS]++;
                }
                else
                {
                    appearedS.Add(curS, 1);
                }
            }

            long result = 0;
            foreach (var curAnagram in appearedS)
            {
                if (curAnagram.Value <= 1) continue;
                result += (curAnagram.Value * (curAnagram.Value - 1)) / 2;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
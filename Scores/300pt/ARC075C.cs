using System;
using System.Linq;
using System.Collections.Generic;
using static System.Console;

namespace _300pt
{
    class ARC075C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            List<int> s = new List<int>();

            int result = 0;
            for (int i = 0; i < N; i++) {
                s.Add(int.Parse(ReadLine()));
                result += s[i];
            }

            while (result % 10 == 0 && s.Count > 0) {
                s.OrderBy(n => n);
                int max = 0;
                for (int j = 0; j < s.Count; j++) {
                    int sumRest = result - s[j];
                    if (sumRest % 10 == 0) sumRest = 0;
                    max = (max < sumRest ? sumRest : max);
                }
                result = max;
                s.RemoveAt(0);
            }

            if (result % 10 == 0) result = 0;

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}

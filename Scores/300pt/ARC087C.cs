using System;
using System.Linq;
using System.Collections.Generic;
using static System.Console;

namespace _300pt
{

    class ARC087C
    {
        static void Main(string[] args)
        {
            //input
            int N = int.Parse(ReadLine());
            List<int> a = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).OrderBy(m => m).ToList();
            HashSet<int> hs = new HashSet<int>(a.Distinct());

            //calculate
            int result = 0;
            foreach (int cur in hs) {
                int count = a.Count(n => n == cur);

                int rest = count - cur;
                if (rest >= 0)
                    result += (count - cur);
                else
                    result += count;
            }

            //output;
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}

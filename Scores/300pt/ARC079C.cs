using System;
using static System.Console;
using System.Linq;
using System.Collections.Generic;

namespace _300pt
{
    class ARC079C
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();

            int N = init[0];   //目的地
            int M = init[1];   //船の便数

            List<int> from1 = new List<int>();
            List<int> toN = new List<int>();

            for (int i = 0; i < M; i++)
            {
                int[] input = ReadLine().Split(' ')
                    .Select(n => int.Parse(n)).ToArray();

                if (input[0] == 1)
                {
                    from1.Add(input[1]);
                }

                if (input[1] == N)
                {
                    toN.Add(input[0]);
                }
            }

            IEnumerable<int> transitionList = from1.Intersect<int>(toN);

            WriteLine(transitionList.Count() > 0 ? "POSSIBLE" : "IMPOSSIBLE");
            ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ABC127D
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int M = init[1];

            long[] A = ReadLine().Split(' ')
                .Select(n => long.Parse(n))
                .OrderBy(n => n).ToArray();

            Dictionary<int, int> changeCard = new Dictionary<int, int>();
            for (int i = 0; i < M; i++)
            {
                int[] data = ReadLine().Split(' ')
                    .Select(n => int.Parse(n)).ToArray();
                int B = data[0];
                int C = data[1];
                if (changeCard.ContainsKey(C))
                {
                    changeCard[C] += B;
                }
                else
                {
                    changeCard.Add(C, B);
                }
            }

            IOrderedEnumerable<KeyValuePair<int, int>> sortedCard
                 = changeCard.OrderByDescending(pair => pair.Key);
            int m = 0;
            bool satisfy = false;
            foreach (KeyValuePair<int, int> pair in sortedCard)
            {
                for (int j = 0; j < pair.Value; j++)
                {
                    if (A[m] > pair.Key)
                    {
                        satisfy = true;
                        break;
                    }
                    A[m] = pair.Key;
                    m++;
                    if (m >= N)
                    {
                        satisfy = true;
                        break;
                    }
                }
                if (satisfy) break;
            }

            WriteLine(A.Sum().ToString());
            ReadLine();
        }
    }
}
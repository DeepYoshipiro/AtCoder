using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace CyanProblems
{
    class Donuts2015B
    {
        static int StandCount(int bit, int N)
        {
            int result = 0;
            for (int i = 0; i < N; i++)
            {
                result += (bit >> i) & 1;
            }
            return result;
        }

        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var N = init[0];
            var M = init[1];

            var A = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();

            var B = new int[M];
            var I = new int[M];
            for (int j = 0; j < M; j++)
            {
                var input = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                B[j] = input[0];
                var C = input[1];
                var II = new int[C];
                Array.Copy(input, 2, II, 0, C);

                for (int k = 0; k < C; k++)
                {
                    I[j] += (int)(1 << (II[k] - 1));
                }                
            }

            const int PICK_IDOL = 9;
            long result = 0;
            for (int bit = 1; bit < (1 << N); bit++)
            {
                if (StandCount(bit, N) != PICK_IDOL) continue;

                int groupAbility = 0;
                for (int i = 0; i < N; i++)
                {
                    groupAbility += A[i] * (int)((bit >> i) & 1);
                }

                for (int j = 0; j < M; j++)
                {
                    groupAbility += StandCount(bit & I[j], N) >= 3
                        ? B[j] : 0;
                }

                result = groupAbility > result ? groupAbility : result;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}

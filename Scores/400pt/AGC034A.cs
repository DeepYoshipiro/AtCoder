using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class AGC034A
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int startA = init[1];
            int startB = init[2];
            int goalA = init[3];
            int goalB = init[4];

            char[] S = (new char[] {' '})
                .Concat(ReadLine().ToCharArray()).ToArray();

            // 道中で2マス連続で、岩マスがつづいたらダメ
            for (int i = startA; i < Max(goalA, goalB) - 1; i++)
            {
                if (S[i] == '#' && S[i + 1] == '#')
                {
                    WriteLine("No");
                    ReadKey();
                    return;
                }
            }

            if (goalA < goalB)
            {
                WriteLine("Yes");
                ReadKey();
                return;
            }

            // goalA > goalB で途中追い抜きがある場合、
            // startBの1マス前から、goalBの1マスまでのどこか
            // 途中3マス連続で空いているマスが空いていないといけない。
            bool result = false;
            for (int i = startB; i <= goalB; i++)
            {
                if (S[i - 1] == '.' && S[i] == '.' && S[i + 1] == '.')
                {
                    result = true;
                    break;
                }
            }

            if (result)
            {
                WriteLine("Yes");
            }
            else
            {
                WriteLine("No");
            }
            ReadKey();
        }
    }
}

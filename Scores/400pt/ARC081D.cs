using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ARC081D
    {
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());

            var S1 = ReadLine().ToCharArray();
            var S2 = ReadLine().ToCharArray();

            if (N == 1)
            {
                WriteLine(3.ToString());
                ReadKey();
                return;
            }

            var way = new long[N];
            bool continueHorizontal = false;
            bool continueVertical = false;
            int cur = 0;
            for (int i = 0; i < N; i++)
            {
                way[i] = 1;
            }

            if (S1[0] == S1[1])
            {
                continueHorizontal = true;
                way[0] = 6;
                continueVertical = false;
                cur += 2;
            }
            else
            {
                continueHorizontal = false;
                way[0] = 3;
                continueVertical = true;
                cur += 1;
            }

            while (cur < N)
            {
                if (cur + 1 < N && S1[cur] == S1[cur + 1])
                {
                    continueVertical = false;
                    if (continueHorizontal) way[cur] = 3;
                    else way[cur] = 2;
                    continueHorizontal = true;
                    cur += 2;
                }
                else
                {
                    continueHorizontal = false;
                    if (continueVertical) way[cur] = 2;
                    else way[cur] = 1;
                    continueVertical = true;
                    cur += 1;
                } 
            }

            long result = 1;
            long MOD = (long)Pow(10, 9) + 7;
            for (int i = 0; i < N; i++)
            {
                result *= way[i];
                result %= MOD;
            }
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}

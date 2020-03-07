using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _200pt
{
    class ABC079B
    {
        static void Main(string[] args)
        {
            const int MAX_N = 86;
            int N = int.Parse(ReadLine());

            long[] lucaNum = new long[MAX_N + 1];
            lucaNum[0] = 2;
            lucaNum[1] = 1;
            for (int i = 2; i <= N; i++)
            {
                lucaNum[i] = lucaNum[i - 1] + lucaNum[i - 2];
            }

            WriteLine(lucaNum[N].ToString());
            ReadKey();
        }
    }
}
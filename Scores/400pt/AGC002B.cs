using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class AGC002B
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int M = init[1];
        
            int[] ballCnt = Enumerable.Repeat(1, N + 1).ToArray();
            ballCnt[0] = 0;

            bool[] inRedAble = new bool[N + 1];
            inRedAble[1] = true;

            for (int i = 0; i < M; i++)
            {
                int[] moveBall = ReadLine().Split(' ')
                    .Select(n => int.Parse(n)).ToArray();
                int x = moveBall[0];
                int y = moveBall[1];

                if (inRedAble[x] == true) inRedAble[y] = true;
                ballCnt[x]--;
                ballCnt[y]++;
                if (ballCnt[x] == 0) inRedAble[x] = false;
            }

            WriteLine(inRedAble.Where(p => p == true).Count());
            ReadKey();
        }

    }
}
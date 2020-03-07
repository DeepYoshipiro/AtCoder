using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ABC053D
    {
        static void Main(string[] args)
        {
            const int MAX_NUM = 100000;
            int N = int.Parse(ReadLine());
            int[] A = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();

            int[] numCnt = new int[MAX_NUM + 1];
            for (int i = 0; i < N; i++)
            {
                numCnt[A[i]]++;
                if (numCnt[A[i]] >= 3) numCnt[A[i]] -= 2;
            }

            Array.Sort(numCnt);
            Array.Reverse(numCnt);

            int two = 0;
            int kind = 0;
            for (int i = 0; i < N; i++)
            {
                if (numCnt[i] == 2) two++;
                else if (numCnt[i] == 0) break;
                kind++;
            }

            kind -= two % 2;
            WriteLine(kind.ToString());
            ReadKey();
        }
    }
}

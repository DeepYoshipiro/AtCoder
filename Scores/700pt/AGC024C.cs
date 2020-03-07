using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace _700pt
{
    class AGC024C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());

            int[] A = new int[N];
            for (int i = 0; i < N; i++)
            {
                A[i] = int.Parse(ReadLine());
            }

            bool possible = true;
            if (A[0] > 0) possible = false;
            for (int i = 1; i < N; i++)
            {
                if (A[i - 1] + 1 < A[i]) possible = false;
            }

            if (!possible)
            {
                WriteLine("−1");
                ReadKey();
                return;
            }
        
            int[] X = new int[N];
            int certain = N;
            for (int cur = N - 1; cur > 0; cur--)
            {
                while (A[cur] != 1)
                {
                    if (A[cur] == 0) certain = cur;
                    cur--;
                }
                A[cur] = A[cur - 1] + 1;
                int cur2 = cur;
                while (cur2 < certain)
                {
                    A[cur2] = A[cur2 - 1] + 1;   
                }
            }




        }
    }
}
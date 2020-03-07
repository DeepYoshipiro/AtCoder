using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace _300pt
{
    class ABC073C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            List<int> A = new List<int>();
            for (int i = 0; i < N; i++)
            {
                A.Add(int.Parse(ReadLine()));
            }
            A.Sort();

            int result = N;
            for (int i = 0; i < A.Count - 1; i++)
            {
                if (A[i] == A[i + 1])
                {
                    result -= 2;
                    i++;
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}

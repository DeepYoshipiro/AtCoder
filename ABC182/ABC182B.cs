using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC182
{
    class ABC182B
    {
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());
            var A = ReadLine().Split()
                .Select(n => int.Parse(n))
                .OrderByDescending(n => n).ToArray();

            int gcdMaxIdx = 0;
            var gcdNum = new int[A[0] + 1];
            for (int d = 2; d <= A[0]; d++)
            {
                int divAble = 0;
                for (int i = 0; i < A.Length; i++)
                {
                    if (A[i] % d == 0)
                    {
                        divAble++;
                        gcdNum[d]++;
                    }
                }
                if (divAble > gcdMaxIdx) gcdMaxIdx = divAble;
            }

            int result = 0;
            for (int d = A[0]; d >= 2; d--)
            {
                if (gcdNum[d] == gcdMaxIdx) 
                {
                    result = d;
                    break;
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}

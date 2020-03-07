using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ARC022B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            int[] A = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();

            int result = 0;
            int right = 0;
            bool[] exist = new bool[100001];

            for (int left = 0; left < N; left++)
            {
                while (right < N && !exist[A[right]])
                {
                    exist[A[right]] = true;
                    right++;
                }
                result = Max(result, right - left);
                if (left == right)
                {
                    right++;
                }
                else
                {
                    exist[A[left]] = false;
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ABC085D
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int H = init[1];

            int[] a = new int[N];
            List<int> b = new List<int>();
            for (int i = 0; i < N; i++)
            {
                int[] spec = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                a[i] = spec[0];
                b.Add(spec[1]);                
            }
            int attack = a.Max();
            b.Sort();
            b.Reverse();

            int result = 0;
            for (int i = 0; i < N; i++)
            {
                if (b[i] <= a.Max())
                {
                    break;
                }
                else
                {
                    result++;
                    H -= b[i];
                    if (H <= 0)
                    {
                        H = 0;
                        break;
                    }
                }
            }

            result += (H + attack - 1) / attack;
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC157
{
    class ABC157C
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int M = init[1];

            int[] c = new int[M];
            char[] s = new char[M];
            for (int i = 0; i < M; i++)
            {
                string[] info = ReadLine().Split();
                c[i] = int.Parse(info[0]) - 1;
                s[i] = char.Parse(info[1]);
            }

            int result = -1;
            int begin = (int)Pow(10, N - 1);
            if (begin == 1) begin = 0;
            for (int j = begin; j <= Pow(10, N) - 1; j++)
            {
                char[] num = j.ToString().ToCharArray();

                bool satisfy = true;
                for (int i = 0; i < M; i++)
                {
                    if (c[i] >= num.Count() || s[i] != num[c[i]])
                    {
                        satisfy = false;
                        break;
                    }
                }
                if (satisfy)
                {
                    result = j;
                    break;
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
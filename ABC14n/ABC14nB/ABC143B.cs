using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;


namespace ABC143
{
    class ABC143B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            int[] d = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();

            int result = 0;
            for (int i = 0; i < N - 1; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    result += d[i] * d[j];
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }

    }
}

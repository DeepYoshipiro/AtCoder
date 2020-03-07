using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace ABC148
{
    class ABC148B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            string[] init = ReadLine().Split().ToArray();

            StringBuilder result = new StringBuilder();
            for (int i = 0; i < 2 * N; i++)
            {
                result.Append(init[i % 2].Substring(i / 2, 1));
            }

            WriteLine(result);
            ReadKey();
        }
    }
}

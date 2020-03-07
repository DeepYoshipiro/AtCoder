using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace Nikkei2019_2_qual
{
    class N19qualA
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            int result = (N % 2 == 0 ? N / 2 - 1: (N - 1) / 2);
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _200pt
{
    class NKI2019exD
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());

            string result = "1" + new String('0', N - 1);

            WriteLine(result);
            ReadKey();
        }
    }
}

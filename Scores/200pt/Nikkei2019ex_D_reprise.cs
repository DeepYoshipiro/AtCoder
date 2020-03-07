using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _200pt
{
    class Nikkei2019ex_D_reprise
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());

            string result = '1' + new string('0', N - 1);

            WriteLine(result);
            ReadKey();
        }
    }
}
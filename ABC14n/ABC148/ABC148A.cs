using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace ABC148
{
    class ABC148A
    {
        static void Main(string[] args)
        {
            int A = int.Parse(ReadLine());
            int B = int.Parse(ReadLine());

            WriteLine((6 - A - B).ToString());
            ReadKey();
        }
    }
}

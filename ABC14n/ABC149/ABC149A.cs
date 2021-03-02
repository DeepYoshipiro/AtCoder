using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;


namespace ABC149
{
    class ABC149A
    {
        static void Main(string[] args)
        {
            string[] input = ReadLine().Split().ToArray();

            WriteLine(input[1] + input[0]);
            ReadKey();
        }
    }
}

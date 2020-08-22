using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class CloneTest
    {
        static void Main(string[] args)
        {
            var original = new int[]{5};
            var cloned = (int[])original.Clone();
            WriteLine(original[0].ToString());
            WriteLine(cloned[0].ToString());
            WriteLine();


            original[0] = 1;
            WriteLine(original[0].ToString());
            WriteLine(cloned[0].ToString());
            WriteLine();

            cloned[0] = 2;
            WriteLine(original[0].ToString());
            WriteLine(cloned[0].ToString());
            ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _100pt
{
    class ABC103A
    {
        static void Main(string[] args)
        {
            int[] A = ReadLine().Split()
                .Select(n => int.Parse(n))
                .OrderBy(n => n).ToArray();
            
            WriteLine(A[2] - A[0]);
            ReadKey();
        }
    }
}
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC155
{
    class ABC155A
    {
        static void Main(string[] args)
        {
            int[] A = ReadLine().Split(' ')
                .Select(n => int.Parse(n))
                .OrderBy(n => n).ToArray();

            bool poor = false;
            if (A[0] == A[1] && A[1] != A[2]) poor = true;
            if (A[1] == A[2] && A[0] != A[1]) poor = true;

            WriteLine(poor ? "Yes" : "No");
            ReadKey();
        }
    }
}

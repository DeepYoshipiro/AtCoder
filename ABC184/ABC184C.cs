using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC184
{
    class ABC184C
    {
        static void Main(string[] args)
        {
            var start = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var r1 = start[0];
            var c1 = start[1];

            var goal = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var r2 = goal[0];
            var c2 = goal[1];

            var Gr = r2 - r1;
            var Gc = Abs(c2 - c1);

            var goalS = Gr + Gc;

            int result = 0;
            while (Gr != 0 || Gc != 0)
            {
                result++;
                if (Abs(Gr + Gc) <= 3)
                {
                    break;
                }
                else
                {
                    var diffS = Gr - Gc;
                    Gr -= diffS / 2;
                    Gc += diffS / 2;
                    // Gc = Gc - Gr < Gc + Gr ? Gc - Gr : Gc + Gr;
                    // Gr = 0; 
                }
                Gc -= Gr;
                Gr = 0;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}

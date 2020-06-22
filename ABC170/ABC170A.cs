using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC170
{
    class ABC170A
    {
        static void Main(string[] args)
        {
            var x = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();

            int result = 0;
            if (x[0] == 0) result = 1;
            if (x[1] == 0) result = 2;
            if (x[2] == 0) result = 3;
            if (x[3] == 0) result = 4;
            if (x[4] == 0) result = 5;
            
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}

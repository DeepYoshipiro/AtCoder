using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC153
{
    class ABC153D
    {
        static void Main(string[] args)
        {
            long result = 0;
            long H = long.Parse(ReadLine());
            long monster = 1;

            while (H > 1)
            {
                result += monster;
                H /= 2;
                monster *= 2;                
            }

            result += monster;

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}

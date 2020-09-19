using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC179
{
    class ABC179A
    {
        static void Main(string[] args)
        {
            var S = ReadLine().ToCharArray();
            
            var result = new string(S);
            if (S.Last() == 's')
            {
                result += "es";
            }
            else
            {
                result += "s";
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}

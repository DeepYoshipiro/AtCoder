using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace HHKB2020
{
    class HHKB2020A
    {
        static void Main(string[] args)
        {
            var S = ReadLine();
            var T = ReadLine();

            WriteLine(S == "Y" ? T.ToUpper() : T);
            ReadKey();
        }
    }
}

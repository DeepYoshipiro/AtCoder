using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC189
{
    class ABC189A
    {
        static void Main(string[] args)
        {
            var C = ReadLine().ToCharArray();
            if (C[0] == C[1] && C[1] == C[2])
            {
                WriteLine("Won");
            }
            else
            {
                WriteLine("Lost");
            }

            ReadKey();
        }
    }
}

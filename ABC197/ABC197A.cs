using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC197
{
    class ABC197A
    {
        static void Main(string[] args)
        {
            var S = ReadLine().ToCharArray();
            WriteLine("{0}{1}{2}", S[1] ,S[2] ,S[0]);
            ReadKey();        
        }
    }
}

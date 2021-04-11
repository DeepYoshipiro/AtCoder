using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC198
{
    class ABC198B
    {
        static void Main(string[] args)
        {
            var S = ReadLine().TrimEnd('0');
            var reverseS = new String(S.ToCharArray().Reverse().ToArray());
            if (S == reverseS)
            {
                WriteLine("Yes");
                ReadKey();
                return;
            };

            WriteLine("No");
            ReadKey();
        }
    }
}

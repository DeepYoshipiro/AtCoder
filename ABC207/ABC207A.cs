using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC207
{
    class ABC207A
    {
        static void Main(string[] args)
        {
            var card = ReadLine().Split()
                .Select(n => int.Parse(n))
                .OrderByDescending(n => n).ToArray();

            WriteLine(card[0] + card[1]);
            ReadKey();
        }
    }
}

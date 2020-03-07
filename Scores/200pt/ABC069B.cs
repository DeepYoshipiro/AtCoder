using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _200pt
{
    class ABC069B
    {
        static void Main(string[] args)
        {
            char[] s = ReadLine().ToCharArray();
            string result
                 = s.First() + (s.Count() - 2).ToString() + s.Last();

            WriteLine(result);
            ReadKey();
        }
    }
}

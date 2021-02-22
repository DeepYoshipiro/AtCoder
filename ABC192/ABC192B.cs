using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC192
{
    class ABC192B
    {
        static void Main(string[] args)
        {
            var S = ReadLine();
            for (int i = 0; i < S.Length; i += 2)
            {
                if (S.Substring(i, 1).ToUpper() == S.Substring(i, 1))
                {
                    WriteLine("No");
                    ReadKey();
                    return;
                }
            }

            for (int i = 1; i < S.Length; i += 2)
            {
                if (S.Substring(i, 1).ToLower() == S.Substring(i, 1))
                {
                    WriteLine("No");
                    ReadKey();
                    return;
                }
            }

            WriteLine("Yes");
            ReadKey();
        }
    }
}

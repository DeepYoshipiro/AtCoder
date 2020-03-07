using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace SumiTrust2019
{
    class SumiTrust2019C
    {
        static void Main(string[] args)
        {
            int X = int.Parse(ReadLine());
            
            bool result = true;
            for (int i = 0; i < 20; i++)
            {
                if (X > i * 105 && X < (i + 1) * 100)
                {
                    result = false;
                }
            }

            WriteLine(result ? "1" : "0");
            ReadKey();
        }
    }
}

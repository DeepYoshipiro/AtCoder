using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace SumiTrust2019
{
    class SumiTrust2019B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());

            for (int i = 1; i <= 50000; i++)
            {
                if (i * 108 / 100 == N)
                {
                    WriteLine(i.ToString());
                    ReadKey();
                    return;
                }
            }

            WriteLine(":(");
            ReadKey();
        }
    }
}

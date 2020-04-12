using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace ABC162
{
    class ABC162A
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());

            bool result = false;
            while (N > 0)
            {
                if (N % 10 == 7)
                {
                    result = true;
                    break;
                }
                N /= 10;
            }

            WriteLine(result ? "Yes" : "No");
            ReadKey();
        }
    }
}

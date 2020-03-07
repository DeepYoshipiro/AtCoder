using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class AGC005A
    {
        static void Main(string[] args)
        {
            char[] X = ReadLine().ToCharArray();

            int result = X.Length;
            int poolS = 0;
            for (int i = 0; i < X.Length; i++) {
                if (X[i].Equals('S'))
                {
                    poolS++;
                }
                else //T
                {
                    if (poolS > 0) {
                        poolS--;
                        result -= 2;
                    }
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}

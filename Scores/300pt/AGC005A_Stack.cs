using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class AGC005A_Stack
    {
        static void Main(string[] args)
        {
            char[] X = ReadLine().ToCharArray();

            int result = X.Length;
            Stack<char> poolS = new Stack<char>();
            for (int i = 0; i < X.Length; i++) {
                if (X[i].Equals('S'))
                {
                    poolS.Push('S');
                }
                else //T
                {
                    if (poolS.Count > 0)
                    {
                        poolS.Pop();
                        result -= 2;
                    }
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}

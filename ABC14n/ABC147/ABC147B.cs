using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC147
{
    class ABC147B
    {
        static void Main(string[] args)
        {
            char[] S = ReadLine().ToCharArray();

            int result = 0;
            for (int i = 0; i < S.Length / 2; i++)
            {
                if (S[i] != S[S.Length - 1 - i])
                {
                    result++;
                }
            }
            
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}

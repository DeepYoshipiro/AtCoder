using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace ABC164
{
    class ABC164C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            
            string[] S = new string[N];
            for (int i = 0; i < N; i++)
            {
                S[i] = ReadLine();
            }

            int result = S.Distinct().Count();
            
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}

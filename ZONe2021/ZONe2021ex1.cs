using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ZONe2021
{
    class ZONe2021ex1
    {
        static void Main(string[] args)
        {
            // var N = 2;
            var N = 31;
            
            var result = new string[N];
            for (int i = 0; i < N; i++)
            {
                var S = ReadLine().ToCharArray();
                for (int j = 0; j < S.Length; j++)
                {
                    S[j] = (char)(S[j] + 13);
                    if (S[j] > 'z')
                    {
                        S[j] = (char)(S[j] - 26);
                    }
                }
                result[i] = new string(S);
            }

            WriteLine();

            for (int i = 0; i < N; i++)
            {
                WriteLine(result[i]);
            }

            ReadLine();
        }
    }
}

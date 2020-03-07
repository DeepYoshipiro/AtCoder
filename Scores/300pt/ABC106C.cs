using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace _300pt
{
    class ABC106C
    {
        static void Main(string[] args)
        {
            //input
            char[] S = ReadLine().ToCharArray();
            long K = long.Parse(ReadLine());
            long frontOnes = 0;

            char result = '1';
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i].Equals('1')) 
                    frontOnes++;
                else
                {
                    result = S[i];
                    break;
                }
            }

            if (K <= frontOnes)
                result = '1';

            WriteLine(result);
            ReadKey();
        }
    }
}

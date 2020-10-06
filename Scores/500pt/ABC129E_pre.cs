using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _500pt
{
    class ABC129E_pre
    {
        static void Main(string[] args)
        {
            // var N = 0b111011011110;
            //var N = 0b110100001011010;
            var N = int.Parse(ReadLine());
            // var N = 14;
            var MAX_LENGTH = Convert.ToString(N, 2).Length;
            WriteLine(N.ToString());
            WriteLine();

            var oneCount = new long[MAX_LENGTH + 1];
            for (int j = 0; j <= N; j++)
            {
                string X = Convert.ToString(j, 2).PadLeft(MAX_LENGTH, '0');
                WriteLine("{0}\t{1}", j.ToString(), X);
                int one = X.Replace("0", "").Length;
                for (int i = j; i >= 0; i--)
                {
                    string S = Convert.ToString(i, 2).PadLeft(MAX_LENGTH, '0');
                    // int Z = S.Replace("0", "").Length;
                    string T = Convert.ToString(j - i, 2).PadLeft(MAX_LENGTH, '0');
                    string U = Convert.ToString((j - i) ^ i, 2).PadLeft(MAX_LENGTH, '0');
                    if (j == (int)((j - i) ^ i))
                    {
                        WriteLine("{0}\t{1}\t{2}\t{3}", S, T, U, j == (int)((j - i) ^ i));
                        oneCount[one]++;
                    }
                }
                WriteLine();
            }
            WriteLine("{0}\t{1}", N, Convert.ToString(N, 2));
            for (int j = 0; j <= MAX_LENGTH; j++)
            {
                WriteLine("{0}:\t{1}\t{2}\t*\t{3}", j, oneCount[j], oneCount[j] / (long)Pow(2, j), (long)Pow(2, j));
            }
            WriteLine();
            WriteLine("Sum:\t" + oneCount.Sum());
            // var N = int.Parse(ReadLine());
            // var init = ReadLine().Split()
            //     .Select(n => int.Parse(n)).ToArray();
            // var N = init[0];
            // var M = init[1];

            // var N = long.Parse(ReadLine());
            // var init = ReadLine().Split()
            //     .Select(n => long.Parse(n)).ToArray();

            // var S = ReadLine().ToCharArray();
            // var S = ReadLine();
            // var S = ReadLine().ToArray();

            // WriteLine("Hello World!");
            ReadKey();
        }
    }
}

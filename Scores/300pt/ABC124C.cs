using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;


namespace _300pt
{
    class ABC124C
    {
        static void Main(string[] args)
        {
            char[] S = ReadLine().ToCharArray();

            if (S.Length == 1)
            {
                WriteLine("0");
                ReadKey();
                return;
            }

            int resultUseFirst = 0;
            char[] pattern = (S[0].Equals('0')
                 ? new char[2]{'0', '1'} : new char[2]{'1', '0'});
            for (int i = 0; i < S.Length; i++)
            {
                if (!S[i].Equals(pattern[i % 2]))
                    resultUseFirst++;
            }

            int resultUseSecond = 0;
            pattern = (S[1].Equals('1')
                 ? new char[2]{'0', '1'} : new char[2]{'1', '0'});
            for (int i = 0; i < S.Length; i++)
            {
                if (!S[i].Equals(pattern[i % 2]))
                    resultUseSecond++;
            }

            int result = (resultUseFirst < resultUseSecond
                 ? resultUseFirst : resultUseSecond);
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
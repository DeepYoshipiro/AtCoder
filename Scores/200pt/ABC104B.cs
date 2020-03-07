using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _200pt
{
    class ABC104B
    {
        static void Main(string[] args)
        {
            char[] S = ReadLine().ToCharArray();

            if (!S[0].Equals('A'))
            {
                WriteLine("WA");
                ReadKey();
                return;
            }

            int largeC = 0;
            for (int c = 2; c < S.Length - 1; c++)
            {
                if (S[c].Equals('C')) largeC++;
            }

            if (largeC != 1 || S[S.Length - 1].Equals('C'))
            {
                WriteLine("WA");
                ReadKey();
                return;
            }

            for (int i = 1; i < S.Length; i++)
            {
                if (!S[i].Equals('C') && (S[i] < 'a' || S[i] > 'z'))
                {
                    WriteLine("WA");
                    ReadKey();
                    return;
                }
            }

            WriteLine("AC");
            ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _200pt
{
    class ABC109B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            string[] W = new string[N];

            bool result = true;
            W[0] = ReadLine();
            char lastLetter = W[0].Last();
            for (int i = 1; i < N; i++)
            {
                W[i] = ReadLine();
                if (!lastLetter.Equals(W[i].First()))
                {
                    result = false;
                }
                lastLetter = W[i].Last();
            }

            Array.Sort(W);

            for (int i = 1; i < N; i++)
            {
                if (W[i - 1].Equals(W[i]))
                {
                    result = false;
                    break;
                }
            }

            WriteLine(result ? "Yes" : "No");
            ReadKey();
        }
    }
}
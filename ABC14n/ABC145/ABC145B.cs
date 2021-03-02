using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC145
{
    class ABC145B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            char[] S = ReadLine().ToArray();

            if (N % 2 != 0)
            {
                WriteLine("No");
                ReadKey();
                return;
            }

            bool result = true;
            for (int i = 0; i < N / 2; i++)
            {
                if (!S[i].Equals(S[i + N / 2]))
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

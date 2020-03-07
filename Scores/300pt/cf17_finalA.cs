using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class cf17_finalA
    {
        static void Main(string[] args)
        {
            List<char> AKIBA = "AKIHABARA".ToList();
            List<char> S = ReadLine().ToList();

            bool result = true;

            for (int i = 0; i < AKIBA.Count; i++)
            {
                if (i < S.Count && S[i].Equals(AKIBA[i]))
                {
                    continue;
                } 
                else
                {
                    S.Insert(i, 'A');
                    if (S[i].Equals(AKIBA[i])) continue;
                    else
                    {
                        result = false;
                        break;
                    }
                }
            }

            if (S.Count > AKIBA.Count)
            {
                result = false;
            }

            WriteLine(result ? "YES" : "NO");
            ReadKey();
        }
    }
}
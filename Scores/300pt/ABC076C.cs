using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace _300pt
{
    class ABC076C
    {
        static void Main(string[] args)
        {
            char[] S = ReadLine().ToCharArray();
            char[] T = ReadLine().ToCharArray();
            char[] U = new char[S.Length];
            S.CopyTo(U, 0);

            bool match = false;
            for (int s = S.Length - T.Length; s >= 0; s--)
            {
                match = true;
                S.CopyTo(U, 0);
                for (int t = 0; t < T.Length; t++)
                {
                    char cur = T[t];
                    if (S[s + t].Equals('?')
                        || S[s + t].Equals(T[t]))
                    {
                        U[s + t] = T[t]; 
                    }
                    else
                    {
                        match = false;
                        break;
                    }
                }
                if (match) break;
            }

            if (match)
            {
                for (int i = 0; i < S.Length; i++)
                {
                    if (U[i].Equals('?')) U[i] = 'a';
                }
                string result = new string(U);
                WriteLine(result);
            }
            else
            {
                WriteLine("UNRESTORABLE");
            }

            ReadKey();
        }
    }
}
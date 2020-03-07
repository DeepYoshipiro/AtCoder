using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _200pt
{
    class ABC098B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            char[] S = ReadLine().ToCharArray();

            int result = 0;
            for (int i = 0; i < N; i++)
            {
                HashSet<char> X = new HashSet<char>();
                HashSet<char> Y = new HashSet<char>();
                for (int j = 0; j <= i; j++)
                {
                    X.Add(S[j]);
                }
                for (int j = i + 1; j < N; j++)
                {
                    Y.Add(S[j]);
                }
                X.IntersectWith(Y);
                if (X.Count > result) result = X.Count; 
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
   
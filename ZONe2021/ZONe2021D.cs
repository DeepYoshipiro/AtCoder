using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ZONe2021
{
    class ZONe2021D
    {
        static void Main(string[] args)
        {
            var S = ReadLine().ToCharArray();
            bool reverse = false;
            var preU = new StringBuilder();
            var U = new StringBuilder();
            for (int i = 0; i < S.Length; i++)
            {
                if (S[i] == 'R')
                {
                    reverse = !reverse;
                }
                else
                {
                    if (reverse)
                    {
                        preU.Append(S[i]);
                    }
                    else
                    {
                        U.Append(S[i]);
                    }
                }
            }
            
            var prepreU = preU.ToString();
            prepreU = new string(prepreU.Reverse().ToArray());
            var T = prepreU + U.ToString();
            if (reverse) T = new string(T.Reverse().ToArray());

            var result = new StringBuilder();
            string sameChar = "";
            for (int i = 0; i < T.Length; i++)
            {
                var nextChar = T.Substring(i, 1);
                if (nextChar == sameChar)
                {
                    result.Remove(result.Length - 1, 1);
                    if (result.Length == 0)
                    {
                        sameChar = "";
                    }
                    else
                    {
                        sameChar = result.ToString(result.Length - 1, 1);
                    }
                }
                else
                {
                    result.Append(nextChar);
                    sameChar = nextChar; 
                }
            }

            WriteLine(result);
            ReadKey();
        }
    }
}

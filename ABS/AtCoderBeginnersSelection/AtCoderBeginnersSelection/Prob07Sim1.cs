using System;
using System.Collections.Generic;
using static System.Console;

namespace AtCoderBeginnersSelection
{
    class Prob07Sim1
    {
        static void Main(string[] args)
        {
            // input
            char[] S = ReadLine().ToCharArray();
            char[] alphabet = {'a','b','c','d','e','f','g','h','i'
                    ,'j','k','l','m','n','o','p','q','r'
                    ,'s','t','u','v','w','x','y','z'};

            Dictionary<char, int> appearedAlphabet = new Dictionary<char, int>();
            foreach (char c in alphabet) {
                appearedAlphabet.Add(c, 0);
            }

            // calculate
            for (int i = 0; i < S.Length; i++)
            {
                appearedAlphabet[S[i]]++;
            }

            string result = "None";
            foreach (char s in alphabet) {
                if (appearedAlphabet[s] == 0)
                {
                    result = s.ToString();
                    break;
                }
            }

            // output
            WriteLine(result.ToString());
        }
    }
}

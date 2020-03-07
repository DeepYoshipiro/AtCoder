using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace AGC039
{
    class AGC039A
    {
        static void Main(string[] args)
        {
            string S = ReadLine();
            int s = S.Length;
            long K = long.Parse(ReadLine());

            long result = 0; 
            if (S[0].Equals(S[s - 1]))
            {
                int i = s - 1;
                while (S.Substring(0, 1).Equals(S.Substring(i, 1))){
                    i--;
                    if (i == 0) {
                        WriteLine((s * K) / 2);
                        ReadKey();
                        return;
                    }
                } 
                i++;
                string trunk = (S + S).Substring(i, s);
                string prefix = S.Substring(0, i);
                string surfix = (S + S).Substring(prefix.Length + trunk.Length);

                result = CountContLetter(trunk) * (K - 1);
                result += CountContLetter(prefix);
                result += CountContLetter(surfix);
            }
            else
            {
                result = CountContLetter(S) * K;
            }

            WriteLine(result.ToString());
            ReadKey();
        }

        static long CountContLetter(string str)
        {
            char[] S = str.ToCharArray();
            int s = str.Length;
            int contCount = 1;
            int result = 0;
            for (int i = 1; i < s; i++)
            {
                if (S[i - 1].Equals(S[i]))
                    contCount++;
                else
                {
                    result += contCount / 2;
                    contCount = 1;
                }
            }
            if (contCount > 1) result += contCount / 2;
            return result;
        }
    }
}
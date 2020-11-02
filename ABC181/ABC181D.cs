using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC181
{
    class ABC181D
    {
        static void Main(string[] args)
        {
            var S = ReadLine().ToCharArray();
            var nC = new int[10];
            for (int i = 0; i < S.Length; i++)
            {
                nC[S[i] - '0']++;
            }

            bool result = false;
            int check = 1000;
            if (S.Length <= 2) check = (int)Pow(10, S.Length);
            for (int i = 0; i < check; i += 8)
            {
                var cond = new int[10];
                if (S.Length >= 3) cond[i / 100]++;
                if (S.Length >= 2) cond[(i % 100) / 10]++;
                cond[i % 10]++;
                result = true;
                for (int j = 0; j < 10; j++)
                {
                    if (nC[j] < cond[j])
                    {
                        result = false;
                        break;
                    } 
                }
                if (result) break;
            }

            WriteLine(result ? "Yes" : "No");
            ReadKey();
        }
    }
}

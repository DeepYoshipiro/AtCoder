using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace ProjectEuler
{
    class Prob206
    {
        static void Main(string[] args)
        {
            const long MAX_ANSWER = 1929394959697989990;
            long maxRoot = (long)Sqrt(MAX_ANSWER);
            const long MIN_ROOT = 1000000000;
            long answer = (long)Pow(MIN_ROOT, 2);
            for (long i = MIN_ROOT; i < maxRoot; i++)
            {
                answer = i * i;
                string s = answer.ToString();
                bool result = true;
                for (int j = 1; j < 10; j++)
                {
                    if (!s[(j - 1) * 2].Equals(j.ToString()))
                    {
                        result = false;
                        break;
                    }
                }
                if (result) break;
            }

            WriteLine(answer.ToString());
            ReadKey();
        }
    }
}
﻿using System;
using static System.Console;
using System.Collections.Generic;
using System.Text;

namespace _300pt
{
    class ARC061C_Sim1
    {
        static void Main(string[] args)
        {
            //input
            string S = ReadLine();

            long result = Func(0, S);

            //output;
            WriteLine(result.ToString());
            ReadKey();
        }

        internal static long Func(long n, string s)
        {
            //StringBuilder ret = new StringBuilder();
            long retNum = 0;
            if (s.Length == 1)
            {
                return n + long.Parse(s);
            }

            retNum = n + long.Parse(s);

            for (int i = 1; i < s.Length; i++)
            {
                retNum += Func(n + long.Parse(s.Substring(0, i)), s.Substring(i));
            }
            return retNum;
        }
    }
}

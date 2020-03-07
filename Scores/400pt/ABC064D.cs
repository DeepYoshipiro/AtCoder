using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ABC064D
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            char[] S = ReadLine().ToCharArray();

            string result = "";
            int openBlacketsPool = 0;

            for (int i = 0; i < N; i++)
            {
                if (S[i].Equals('('))
                {
                    if (openBlacketsPool < 0)
                    {
                        result = new string('(', -openBlacketsPool) 
                            + result;
                        openBlacketsPool = 0; 
                    }
                    // '(' OpenBlacket
                    openBlacketsPool++;
                }
                else
                {
                    // ')' CloseBlacket
                    openBlacketsPool--;
                }
                result += S[i];

            }
            
            if (openBlacketsPool > 0)
            {
                result += new string(')', openBlacketsPool);
            }
            if (openBlacketsPool < 0)
            {
                result = new string('(', -openBlacketsPool) 
                    + result;
            }

            WriteLine(result);
            ReadKey();

        }
    }
}
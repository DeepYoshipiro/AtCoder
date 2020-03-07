using System;
using System.Linq;
using System.Collections.Generic;
using static System.Console;
using static System.Math;

namespace ABC141
{
    class ABC141B
    {
        static void Main(string[] args)
        {
            char[] S = ReadLine().ToCharArray();

            bool easy = true;
            for (int i = 0; i < S.Length; i += 2) {
                //こっちが奇数番目のステップ
                if (S[i].Equals('L'))
                {
                    easy = false;
                    break;
                }
            }

            for (int i = 1; i < S.Length; i += 2) {
                //こっちは偶数番目
                if (S[i].Equals('R'))
                {
                    easy = false;
                    break;
                }
            }

            WriteLine(easy ? "Yes": "No");
            ReadKey();
        }
    }
}

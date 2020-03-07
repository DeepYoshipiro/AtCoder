using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ABC042D
    {
        const long M = 1000000007;
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int H = init[0];
            int W = init[1];
            int A = init[2];
            int B = init[3];

            long result = 0;

            for (int i = 0; i <= B && A + i <= H - 1; i++)
            {
                result += Combination((H - 1) - A + B, B - i)
                    * Combination((W - 1) - B + A, A + i) % M;
            }

            WriteLine(result.ToString());
            ReadKey();
        }

        /// <summary>
        /// 異なるn個のものからm個を選ぶ
        /// 組み合わせの総数 nCmを取得する。
        /// </summary>
        /// <param name="n">n</param>
        /// <param name="m">m</param>
        /// <returns>nＣm</returns>
        public static long Combination(long n, long m)
        {    //以下の漸化式に従って、再帰により算出する。

                //（１）m＝0の場合、
                //      nＣm ＝ 1
                
            if (m ==  0)    
            {        
                return 1;    
            }

                //（２）m≠0の場合、
                //      nＣm ＝ nＣm-1 ×（n-m+1）/ m 
                
            return (Combination(n,  m - 1) * (n - m + 1) / m) % M;

        }
    }
}
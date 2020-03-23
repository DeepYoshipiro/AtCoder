using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC154
{
    class ABC154Erev
    {
        static void Main(string[] args)
        {
            char[] N = ReadLine().ToCharArray();
            int K = int.Parse(ReadLine());  // not 0

            long[,,] dp = new long[N.Count(), K + 2, 2];
            dp[0, 0, 1] = 1;    //見ている桁、0の個数、前の桁までNと等しいか
            dp[0, 0, 0] = N[0] - '0' - 1;
            for (int d = 1; d < N.Count(); d++)
            {
                for (int k = 0; k < N.Count() - 1; k++)
                {
                    if (dp[d - 1, k, 1] > 0)
                    {
                        if (N[d].Equals('0'))
                        {
                            dp[d, k, 1] += dp[d - 1, k, 1];
                        }
                        else
                        {
                            dp[d, k + 1, 1] += dp[d - 1, k, 1];
                            dp[d, k + 1, 0]
                                += (N[d] - '0' - 1) * dp[d - 1, k, 1];
                            dp[d, k, 0]
                                += dp[d - 1, k, 1]; 
                        }
                    }
                    //else
                    {
                        dp[d, k, 0] += dp[d - 1, k, 0];
                        dp[d, k + 1, 0] += 9 * dp[d - 1, k, 0];
                    }
                }
            }
            WriteLine("{0} {1}", dp[N.Count() - 1, K, 1], dp[N.Count() - 1, K, 0]);
            ReadKey();
        }
    }
}

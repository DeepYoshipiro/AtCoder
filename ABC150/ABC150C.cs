using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace ABC150
{
    class ABC150C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            List<int> restP = new List<int>();
            List<int> restQ = new List<int>();
            for (int i = 1; i <= N; i++)
            {
                restP.Add(i);
                restQ.Add(i);
            }

            int[] P = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int[] Q = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();

            ABC150C me = new ABC150C();
            int orderP = 0;
            int orderQ = 0;
            for (int j = 0; j < N; j++)
            {
                for (int i = 0; i < N - j; i++)
                {
                    if (restP[i] == P[j])
                    {
                        orderP += me.Factorial(N - j - 1) * i;
                        restP.RemoveAt(i);
                        break;
                    }
                }

                for (int i = 0; i < N - j; i++)
                {
                    if (restQ[i] == Q[j])
                    {
                        orderQ += me.Factorial(N - j - 1) * i;
                        restQ.RemoveAt(i);
                        break;
                    } 
                }
            }

            int result = Abs(orderP - orderQ);
            WriteLine(result.ToString());
            ReadKey();
        }

        internal int Factorial(int n)
        {
            if (n == 0 || n == 1) return 1;
            int result = n * Factorial(n - 1);
            return result;
        }
    }
}

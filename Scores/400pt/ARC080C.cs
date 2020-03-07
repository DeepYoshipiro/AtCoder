using System;
using static System.Console;
using System.Linq;

namespace _400pt
{
    class ARC080C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            int[] A = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();

            int D = 0;  //奇数の個数（oDdの略）
            int F = 0;  //4の倍数の個数（Fourの略）

            for (int i = 0; i < N; i++)
            {
                switch (A[i] % 4) {
                    case 0:
                        F++;
                        break;
                    case 2:
                        break;
                    default:
                        D++;
                        break;
                }                
            }

            bool result;
            if (D <= F) result = true;
            else if ((D <= F + 1) && (D + F == N)) result = true;
            else result = false;

            WriteLine(result ? "Yes" : "No");
            ReadKey();
        }
    }
}

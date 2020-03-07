using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace Nikkei2019_2_qual
{
    class N19qualB
    {
        static void Main(string[] args)
        {
            const long DIVIDE = 998244353;
            int N = int.Parse(ReadLine());
            long[] D = ReadLine().Split(' ')
                .Select(n => long.Parse(n))
                .ToArray();

            if (D[0] != 0)
            {
                WriteLine("0");
                ReadKey();
                return;
            }
            else if (D.Length == 1)
            {
                WriteLine("1");
                ReadKey();
                return;
            }

            long[] DCnt = new long[N];
            for (int i = 0; i < N; i++)
            {
                DCnt[D[i]]++;
            }

            if (DCnt[1] == 0)
            {
                WriteLine("0");
                ReadKey();
                return;
            }

            long result = 1;
            for (int i = 2; i < N; i++)
            {
                if (DCnt[i] > 0 && DCnt[i - 1] == 0)
                {
                    WriteLine("0");
                    ReadKey();
                    return;
                }
                for (int j = 1; j <= DCnt[i]; j++)
                {
                    result *= DCnt[i - 1];
                    result %= DIVIDE;
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
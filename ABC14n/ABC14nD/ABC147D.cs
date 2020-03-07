using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC147
{
    class ABC147D
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            ulong[] A = ReadLine().Split()
                .Select(n => ulong.Parse(n)).ToArray();

            ulong result = 0;
            ulong mod = (ulong)Pow(10, 9) + 7;
            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    result += (A[i] ^ A[j]) % mod;
                    result %= mod;
                }
            }

            WriteLine(result.ToString());
            ReadLine();
        }
    }
}

            

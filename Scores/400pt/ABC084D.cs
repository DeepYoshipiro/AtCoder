using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ABC084D
    {
        const int maxNum = 100000;
        static void Main(string[] args)
        {
            int Q = int.Parse(ReadLine());

            int[] like2017NumCnt = new int[maxNum + 1];

            bool[] IsPrime = IsPrimeArray();
            int cnt = 0;
            for (int i = 3; i <= maxNum; i++)
            {
                if (IsPrime[i] && IsPrime[(i + 1) / 2])
                    cnt++;
                like2017NumCnt[i] = cnt;
            }

            int[] l = new int[Q];
            int[] r = new int[Q];
            for (int i = 0; i < Q; i++)
            {
                int[] input = ReadLine().Split(' ')
                        .Select(n => int.Parse(n)).ToArray();    
                l[i] = input[0];
                r[i] = input[1];
            }

            for (int i = 0; i < Q; i++)
            {
                WriteLine(like2017NumCnt[r[i]] - like2017NumCnt[l[i] - 1]);
            }
 
            ReadKey();
        }

        internal static bool[] IsPrimeArray() 
        {
            bool[] sieve = (new bool[maxNum + 1]).Select(v => true).ToArray();
            sieve[0] = false;
            sieve[1] = false;
            int squareroot = (int)Math.Sqrt(maxNum);
            for (int i = 2; i <= squareroot; i++) {
                if (!sieve[i])
                    continue;
                for (int n = i * 2; n <= maxNum; n += i)
                    sieve[n] = false;
            }
            return sieve;
        }
    }
}
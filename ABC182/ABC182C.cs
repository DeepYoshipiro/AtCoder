using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC182
{
    class ABC182C
    {
        static void Main(string[] args)
        {
            var S = ReadLine().ToCharArray();
            var N = S.Length;
            var num = new int[N];
            int sum = 0;
            for (int i = 0; i < N; i++)
            {
                num[i] = S[i] - '0';
                sum += num[i];
            }

            if (sum % 3 == 0)
            {
                WriteLine("0");
                ReadKey();
                return;
            }

            for (int i = 0; i < N; i++)
            {
                if ((sum - num[i]) % 3 == 0)
                {
                    if (N == 1) WriteLine("-1");
                    else WriteLine("1");
                    ReadKey();
                    return;
                } 
            }
            
            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                if ((sum - num[i] - num[j]) % 3 == 0)
                {
                    if (N <= 2) WriteLine("-1");
                    else WriteLine("2");
                    ReadKey();
                    return;
                } 
            }

            WriteLine("-1");
            ReadKey();
        }
    }
}

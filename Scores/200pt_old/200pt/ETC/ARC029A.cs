using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace ETC
{
    class ARC029A
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            int[] t = new int[N];

            for (int i = 0; i < N; i++)
            {
                t[i] = int.Parse(ReadLine());
            }

            int allSum = t.Sum();
            int result = allSum;

            for (int bit = 0; bit < 1 << (N - 1); bit++)
            {
                int panA_sum = 0;
                int panB_sum = 0; // 部分集合の和
                for (int i = 0; i < N; i++) {
                    if ((bit & (1 << i)) == (1 << i)) 
                    { // i が S に入っているなら足す
                        panA_sum += t[i];
                    }
                    else
                    {
                        panB_sum += t[i];    
                    }
                }
                
                int sum = Max(panA_sum, panB_sum);
                result = (result > sum ? sum : result);
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC093C
    {
        static void Main(string[] args)
        {
            const int NUM_CNT = 3;
            int[] num = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();

            int result = 0;
            int max = num.Max();
            int maxNumCnt = 0;
            for (int i = 0; i < NUM_CNT; i++)
            {
                int add2Cnt = (max - num[i]) / 2;
                num[i] += add2Cnt * 2;
                result += add2Cnt;

                if (max == num[i]) maxNumCnt++;
            }

            switch (maxNumCnt)
            {
                case 1:
                    result++;
                    break;
                case 2:
                    result += 2;
                    break;
                case 3:
                    break;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
// Solution : Consideration
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC161
{
    class ABC161D
    {
        static void Main(string[] args)
        {
            int K = int.Parse(ReadLine());
            List<long>[] digitLunlunNum = new List<long>[100];
            int curDigit = 0;
            digitLunlunNum[0] = new List<long>{1, 2, 3, 4, 5, 6, 7, 8, 9};
            int cntLunlun = digitLunlunNum[0].Count();
            while (cntLunlun < K)
            {
                curDigit++;
                digitLunlunNum[curDigit] = new List<long>();
                foreach (long oldNum in digitLunlunNum[curDigit - 1])
                {
                    long mod10 = oldNum % 10;
                    for (long diff = -1; diff <= 1; diff++)
                    {
                        if (mod10 + diff >= 0 && mod10 + diff <= 9)
                        {
                            digitLunlunNum[curDigit].Add(oldNum * 10 + (mod10 + diff));
                            cntLunlun++;
                        }
                    }
                }
            }

            List<long> LunlunNum = new List<long>();
            for (int i = 0; i <= curDigit; i++)
            {
                LunlunNum.AddRange(digitLunlunNum[i]);
            }
            LunlunNum.Sort();

            WriteLine(LunlunNum[K - 1]);
            ReadKey();
        }
    }
}

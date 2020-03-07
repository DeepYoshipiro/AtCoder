using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;
using System.Numerics;

namespace ABC155
{
    class ABC155E
    {
        static void Main(string[] args)
        {
            BigInteger N = BigInteger.Parse(ReadLine());

            long result = 0;
            int kari = 0;
            while (N > 0)
            {
                BigInteger curNum = N % 10;
                if (curNum == 0)
                {
                    curNum += kari;
                }
                kari = 0;

                if (curNum >= 6)
                {
                    result += 1;
                    result += 10 - (long)curNum;
                    kari = 1;
                }
                else
                {
                    result += (long)curNum;
                }
                N /= 10;
            }
//            if (kari > 0) result += kari;

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}

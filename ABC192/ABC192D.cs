using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC192
{
    class ABC192D
    {
        static char[] X;
        static long M;

        static void Main(string[] args)
        {
            X = ReadLine().ToCharArray();
            M = long.Parse(ReadLine());

            if (X.Count() == 1)
            {
                if (X[0] - '0' > M)
                {
                    WriteLine("0");
                }
                else
                {
                    WriteLine("1");
                }
                ReadKey();
                return;
            }

            Array.Reverse(X);
            long d = X.Max() - '0';

            if (!Judge(d + 1))
            {
                WriteLine("0");
                ReadKey();
                return;
            }
            
            var goodSmall = d + 1;
            var tooBig = M + 1;

            while (tooBig - goodSmall > 1)
            {
                var trialMid = (goodSmall + tooBig) / 2;
                if (Judge(trialMid))
                {
                    goodSmall = trialMid;
                }
                else
                {
                    tooBig = trialMid;
                }
            }

            var result = goodSmall - d;
            WriteLine(result.ToString());
            ReadKey();
        }

        static bool Judge(long d)
        {
            long curNum = X.First() - '0';
            var diffM = M - curNum;
            long curPlace = 1;
            for (int i = 1; i < X.Count(); i++)
            {
                long limit = (long)Pow(10, 18) / curPlace;
                if (d > limit) return false;
                curPlace *= d;
                long add = curPlace * (long)(X[i] - '0');
                if (curPlace < 0 || curPlace > diffM || add < 0 || add > diffM)
                {
                    return false;
                }
                else
                {
                    curNum += add;
                    diffM -= add;
                }
            }
            return true;
        }
    }
}

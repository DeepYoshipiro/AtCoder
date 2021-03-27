using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC197
{
    class ABC197C
    {
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());
            var A = ReadLine().Split()
                .Select(n => long.Parse(n)).ToArray();

            long result = long.MaxValue;
            for (long bit = 0; bit < 1 << (N - 1); bit++)
            {
                var ORvalues = new List<long>();
                long curORvalue = -1;
                for (int i = 0; i < N; i++)
                {
                    curORvalue = curORvalue == -1
                        ? A[i] : curORvalue | A[i];
                    if ((bit >> i & 1) == 1)
                    {
                        ORvalues.Add(curORvalue);
                        curORvalue = -1;                        
                    }
                }
                if (curORvalue >= 0)
                {
                    ORvalues.Add(curORvalue);
                }

                long XOR = 0;
                foreach (long ORvalue in ORvalues)
                {
                    XOR ^= ORvalue;
                }
                result = XOR < result ? XOR : result;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}

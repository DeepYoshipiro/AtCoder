using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC192
{
    class ABC192C
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => long.Parse(n)).ToArray();
            var N = init[0];
            var K = (int)init[1];

            var CharN = init[0].ToString().ToCharArray();

            long prevA = 0;
            long result = N;
            for (int i = 1; i <= K; i++)
            {
                Array.Sort(CharN);
                var CharMin = new string(CharN).ToArray();
                Array.Reverse(CharN);
                var CharMax = new string(CharN).ToArray();

                long Min = 0;
                long Max = 0;
                for (int j = 0; j < CharN.Length; j++)
                {
                    Max += CharMax[j];
                    Min += CharMin[j];
                    Max *= 10;
                    Min *= 10;                   
                }
                Max /= 10;
                Min /= 10;

                result = Max - Min;
                if (result == prevA) break;

                prevA = result;
                CharN = result.ToString().ToCharArray();
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ABC124D
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int K = init[1];

            char[] S = new char[]{' '}
                .Concat(ReadLine().ToCharArray())
                .ToArray();

            List<int> segmentEnd = new List<int>();
            segmentEnd.Add(0);
            if (S[1].Equals('0')) segmentEnd.Add(0);

            char curS = S[1];
            for (int i = 1; i <= N; i++)
            {
                if (!curS.Equals(S[i]))
                {
                    segmentEnd.Add(i - 1);
                    curS = S[i];
                }
            }
            segmentEnd.Add(N);

            if (segmentEnd.Count % 2 != 0) segmentEnd.Add(N);
            if (segmentEnd.Count <= 2 * K + 2)
            {
                WriteLine(N.ToString());
                ReadKey();
                return;
            }

            int result = 0;
            for (int i = 0; i <= segmentEnd.Count - 1 - 2 * K; i += 2)
            {
                int cur = segmentEnd[i + 2 * K + 1] - segmentEnd[i]; 
                if (cur > result) result = cur;
            }

            WriteLine(result.ToString());
            ReadKey();            
        }
    }
}
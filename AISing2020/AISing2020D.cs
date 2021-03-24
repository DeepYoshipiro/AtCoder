using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace AISing2020
{
    class AISing2020D
    {
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());

            var X = ReadLine().ToCharArray();
            // char[] X = Enumerable.Repeat<char>('1', N).ToArray();
            // char[] X = Enumerable.Repeat<char>('0', N).ToArray();
            var initPopCount = X.Where(c => c == '1').Count();
            
            var restDigit = new int[N][]
                .Select(v => new int[2]).ToArray();

            restDigit[N - 1][0]
                = initPopCount - 1 <= 0 ? 1 : 1 % (initPopCount - 1);
            restDigit[N - 1][1] = 1;

            var sumCurPopCount = new int[N][]
                .Select(v => new int[2]).ToArray();
            sumCurPopCount[N - 1][0] = restDigit[N - 1][0] * (X[N - 1] - '0');
            sumCurPopCount[N - 1][1] = restDigit[N - 1][1] * (X[N - 1] - '0');
            for (int i = N - 2; i >= 0; i--)
            {
                int curDigit = X[i] - '0';

                restDigit[i][0]
                    = initPopCount - 1 <= 0 
                        ? 0 : (restDigit[i + 1][0] * 2) % (initPopCount - 1);
                restDigit[i][1]
                    = (restDigit[i + 1][1] * 2) % (initPopCount + 1);

                sumCurPopCount[i][0]
                    = sumCurPopCount[i + 1][0] + restDigit[i][0] * curDigit;
                sumCurPopCount[i][1]
                    = sumCurPopCount[i + 1][1] + restDigit[i][1] * curDigit;

                sumCurPopCount[i][0]
                    %= initPopCount - 1 <= 0 ? 1 : initPopCount - 1; 
                sumCurPopCount[i][1]
                    %= initPopCount + 1;                
            }

            var popCount = new int[N + 1];
            for (int j = 1; j <= N; j++)
            {
                var curJ = j;
                while (curJ > 0)
                {
                    popCount[j] += curJ % 2;
                    curJ /= 2;
                }
            }

            for (int i = 0; i < N; i++)
            {
                int result = 1;

                int nextN = 1;
                int cur = X[i] - '0';
                switch (cur)
                {
                    case 0:
                        nextN = (sumCurPopCount[0][1] + restDigit[i][1]) % (initPopCount + 1);
                        break;
                    case 1:
                        if (initPopCount - 1 <= 0) 
                        {   
                            nextN = 0;
                            result = 0;
                            break;
                        }
                        nextN = (sumCurPopCount[0][0] - restDigit[i][0]);
                        nextN %= initPopCount - 1 <= 0 ? 1 : initPopCount - 1;
                        if (nextN < 0) nextN += initPopCount - 1;
                        break;
                }

                while (nextN > 0)
                {
                    result++;
                    nextN %= popCount[nextN];
                }
                WriteLine(result.ToString());
            }
            ReadKey();
        }
    }
}

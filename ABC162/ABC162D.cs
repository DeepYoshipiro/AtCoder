using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace ABC162
{
    class ABC162D
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            char[] S = ReadLine().ToCharArray();

            int R = 0;
            int G = 1;
            int B = 2;
            
            int[] C = new int[N];
            int[][] cntC = new int[N + 1][];
            for (int i = 0; i <= N; i++)
            {
                cntC[i] = new int[3];
            }

            for (int i = 0; i < N; i++)
            {
                switch(S[i])
                {
                    case 'R':
                        C[i] = R;
                        break;
                    case 'G':
                        C[i] = G;
                        break;
                    case 'B':
                        C[i] = B;
                        break;
                }
                cntC[i][C[i]]++;    
                for (int j = 0; j < 3; j++)
                {
                    cntC[i + 1][j] = cntC[i][j];
                }
            }     

            long result = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N - 1; j++)
                {
                    if (C[i] == C[j]) continue;
                    int diff = j - i;
                    int unused = 3 - C[i] - C[j];

                    result += cntC[N][unused] - cntC[j][unused];
                    if (j + diff < N && C[j + diff] == unused) result--;   
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}

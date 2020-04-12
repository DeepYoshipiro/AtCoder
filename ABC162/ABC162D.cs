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
            List<int>[] cntC = new List<int>[3];
            for (int i = 0; i < 3; i++)
            {
                cntC[i] = new List<int>();
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
                cntC[C[i]].Add(i);
            }     

            long result
                 = cntC[R].Count() * cntC[G].Count() * cntC[B].Count();
            for (int r = 0; r < cntC[R].Count(); r++)
            {
                for (int g = 0; g < cntC[G].Count(); g++)
                {
                    int diff = Abs(cntC[R][r] - cntC[G][g]);
                    int min = Min(cntC[R][r], cntC[G][g]) - diff;
                    int max = Max(cntC[R][r], cntC[G][g]) + diff;
                    
                    if (min >= 0 && C[min] == B) result--;
                    if (max < N && C[max] == B) result--;

                    int mid = (cntC[R][r] + cntC[G][g]) / 2;
                    if (diff % 2 == 0 && C[mid] == B) result--;
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}

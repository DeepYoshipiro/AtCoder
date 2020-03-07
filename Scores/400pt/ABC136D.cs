using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ABC136D
    {
        static void Main(string[] args)
        {
            char[] S = ReadLine().ToCharArray();
            int[] children = new int[S.Length];
            List<int> RtoL = new List<int>();
            List<int> LtoR = new List<int>();
            for (int i = 0; i < S.Length - 1; i++)
            {
                if (!S[i].Equals(S[i + 1]))
                {
                    if (S[i].Equals('R'))
                    {
                        RtoL.Add(i + 1);
                        LtoR.Add(i);
                    }
                }
            }
            LtoR.Add(S.Length);

            int idxR = 0;
            int idxL = 0;
            for (int i = 0; i < S.Length; i++)
            {
                int orient = (S[i].Equals('R') ? 1 : -1);
                int j = i;
                int move = 0;

                if (orient == 1)
                {
                    if (i > RtoL[idxR]) idxR++;
                    move = RtoL[idxR] - i;
                    if (move % 2 != 0) move--;
                    j += move;
                }
                else
                {
                    if (i >= LtoR[idxL + 1]) idxL++;
                    move = i - LtoR[idxL];
                    if (move % 2 != 0) move--;
                    j -= move;
                }

                children[j]++;
            }

            for (int i = 0; i < S.Length; i++)
            {
                Write(children[i].ToString() + " ");
            }
            ReadKey();
        }
    }
}

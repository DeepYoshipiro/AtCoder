using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC157
{
    class ABC157B
    {
        static void Main(string[] args)
        {
            int[][] A = new int[3][];
            bool[][] called = new bool[3][];
            for (int i = 0; i < 3; i++)
            {
                A[i] = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                called[i] = new bool[3];
            }

            int N = int.Parse(ReadLine());
            for (int m = 0; m < N; m++)
            {
                int number = int.Parse(ReadLine());
                for (int i = 0; i < 3; i++)
                {
                    for (int j = 0; j < 3; j++)
                    {
                        if (A[i][j] == number) 
                        {
                            called[i][j] = true;
                        }
                    }
                }
            }

            bool bingo = false;
            if (called[0][0] && called[1][1] && called[2][2]) bingo = true;
            if (called[0][2] && called[1][1] && called[2][0]) bingo = true;
            for (int i = 0; i < 3; i++)
            {
                if (called[i][0] && called[i][1] && called[i][2]) bingo = true;
            }
            for (int j = 0; j < 3; j++)
            {
                if (called[0][j] && called[1][j] && called[2][j]) bingo = true;
            }

            WriteLine(bingo ? "Yes" : "No");
            ReadKey();
        }
    }
}

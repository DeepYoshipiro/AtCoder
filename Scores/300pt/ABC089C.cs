using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC089C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            string[] S = new string[N];

            string[] MARCH = {"M", "A", "R", "C", "H"};
            int[] MARCH_Count = new int[MARCH.Length];
            for (int i = 1; i <= N; i++)
            {
                string name = ReadLine();
                for (int j = 0; j < MARCH.Length; j++)
                {
                    if (name.Substring(0, 1).Equals(MARCH[j]))
                        MARCH_Count[j]++;
                }
            }

            long result = 0;
            int[,] combination
                 ={{0, 1, 2}, {0, 1, 3}, {0, 1, 4}
                   ,{0, 2, 3}, {0, 2, 4}, {0, 3, 4}
                   ,{1, 2, 3}, {1, 2, 4}, {1, 3, 4}
                   ,{2, 3, 4}};
            for (int i = 0; i < combination.GetLength(0); i++)
            {
                long choice = 1;
                for (int j = 0; j < combination.GetLength(1); j++)
                {
                    choice *= MARCH_Count[combination[i, j]];
                }
                result += choice;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
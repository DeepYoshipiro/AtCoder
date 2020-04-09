// Solution : DFS
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace JudgeUpdate202004
{
    class JudgeUpdate202004_Crev
    {
        static int[] A;
        static int[] ShelfWidth;
        static void Main(string[] args)
        {
            A = (new int[]{0}).Concat(ReadLine().Split(' ')
                .Select(n => int.Parse(n))).ToArray();

            ShelfWidth = new int[4];
            for (int horizonal = 1; horizonal <= 3; horizonal++)
            {
                for (int shelf = 1; shelf <= 3; shelf++)
                {
                    if (A[horizonal] >= shelf) ShelfWidth[shelf] = horizonal;
                } 
            }

            int[] filledGridOnShelf = new int[4];
            filledGridOnShelf[0] = 3;
            filledGridOnShelf[1] = 1;
            int result = dfs(1, filledGridOnShelf);
            WriteLine(result.ToString());
            ReadLine();
        }

        static int dfs(int curNum, int[] filled)
        {
            if (curNum == A.Sum()) return 1;
            int result = 0;
            for (int i = 1; i <= 3; i++)
            {
                if (filled[i] < filled[i - 1]
                    && filled[i] + 1 <= ShelfWidth[i])
                {
                    int[] newFilled = (int[])filled.Clone();
                    newFilled[i]++;
                    result += dfs(curNum + 1, newFilled);
                }
            }
            return result;
        }
    }
}
using System;
using static System.Console;
using System.Linq;

namespace _300pt
{
    class ABC104C
    {
        private static int Difficulty;
        private static int GrandScore;
        private static int[] Problem;
        private static int[] CompleteBonus;

        private static int[] SummedUpAllScores;

        private static int MinSolve;

        static void Main(string[] args)
        {
            //input
            int[] input = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            Difficulty = input[0];
            GrandScore = input[1];

            Problem = new int[Difficulty + 1];
            CompleteBonus = new int[Difficulty + 1];
            MinSolve = 0;
            SummedUpAllScores = new int[Difficulty + 1];

            SummedUpAllScores[0] = 0;

            for (int i = 1; i <= Difficulty; i++)
            {
                SummedUpAllScores[i] = SummedUpAllScores[i - 1];
                input = ReadLine().Split(' ')
                    .Select(n => int.Parse(n)).ToArray();
                Problem[i] = input[0];
                CompleteBonus[i] = input[1];
                MinSolve += Problem[i];
                SummedUpAllScores[i] += i * 100 * Problem[i] + CompleteBonus[i];
            }

            //calculate
            Planning(Difficulty, 0, 0);

            //output;
            WriteLine(MinSolve.ToString());
            ReadKey();
        }

        internal static void Planning(int curLvl, int curScore, int curSolved)
        {
            if (curScore >= GrandScore)
            {
                if (curSolved < MinSolve) MinSolve = curSolved;
                return;
            }

            if (curScore + SummedUpAllScores[curLvl] < GrandScore) return;

            int oneSolveScore = curLvl * 100;
            Planning(curLvl - 1, curScore + oneSolveScore * Problem[curLvl] + CompleteBonus[curLvl]
                , curSolved + Problem[curLvl]);

            for (int i = Problem[curLvl] - 1; i > 0; i--)
            {
                Planning(curLvl - 1, curScore + oneSolveScore * i, curSolved + i);
            }
            return;
        }
    }
}

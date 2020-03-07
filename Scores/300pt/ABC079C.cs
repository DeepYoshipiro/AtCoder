using System;
using static System.Console;
using System.Linq;

namespace _300pt
{
    class ABC079C
    {
        static string Result = "";

        static void Main(string[] args)
        {
            //input
            string S = ReadLine();

            int startNum = int.Parse(S.Substring(0, 1));
            string baseFormula = S.Substring(0, 1);
            string rest = (S.Length > 0 ? S.Substring(1) : "");
            DFS(startNum, baseFormula, rest);

            //output;
            WriteLine(Result.ToString());
            ReadKey();
        }

        internal static void DFS(int m, string current, string rest)
        {
            if (Result.Length > 0) return;
            if (rest.Length == 0)
            {
                if (m ==7) Result = current + "=7";
                return;
            }

            int nextNum = int.Parse(rest.Substring(0, 1));
            string newRest = (rest.Length > 0 ? rest.Substring(1) : "");

            string newAdd = current + "+" + rest.Substring(0, 1);
            DFS(m + nextNum, newAdd, newRest);

            string newSubtract = current + "-" + rest.Substring(0, 1);
            DFS(m - nextNum, newSubtract, newRest);

            return;
        }
    }
}

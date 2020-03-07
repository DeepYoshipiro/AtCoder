using System;
using static System.Console;
using System.Linq;

namespace _300pt
{
    class ARC098C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            char[] S = ReadLine().ToCharArray();

            int minChange = N;
            int westernW = 0;
            int easternE = S.Count(s => s == 'E');

            for (int i = 0; i < N; i++)
            {
                if (S[i].Equals('E')) { easternE--; }
                if (westernW + easternE < minChange) { minChange = westernW + easternE; }
                if (S[i].Equals('W')) { westernW++; }
            }

            WriteLine(minChange.ToString());
            ReadKey();
        }
    }
}

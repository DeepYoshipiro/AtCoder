using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class Diverta2019C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());

            int result = 0;

            int firstB = 0;
            int lastA = 0;
            int firstB_and_lastA = 0;
            for (int i = 0; i < N; i++)
            {
                char[] s = ReadLine().ToCharArray();
                if (s[0].Equals('B') && s[s.Length - 1].Equals('A'))
                    firstB_and_lastA++;
                else if (s[0].Equals('B')) firstB++;
                else if (s[s.Length - 1].Equals('A')) lastA++;
                for (int j = 0; j < s.Length - 1; j++)
                {
                    if (s[j].Equals('A') && s[j + 1].Equals('B'))
                        result++;
                }
            }

            if (firstB + firstB_and_lastA == N)
            {
                if (firstB > 0) firstB--;
                else firstB_and_lastA--;
            }

            while (lastA > 0 || firstB_and_lastA > 0)
            {
                if (firstB > 0)
                {
                    firstB--;
                }
                else if (firstB_and_lastA > 0)
                {
                    firstB_and_lastA--;
                    lastA++;
                }
                else
                {
                    break;
                }
                if (lastA > 0) lastA--;
                else firstB_and_lastA--;
                result++;
            }
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
    
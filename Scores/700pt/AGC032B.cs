using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace _700pt
{
    class AGC032B
    {
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());

            var ngNum = (N % 2 == 0 ? 1 + N : N);
            var edge = new List<Tuple<int, int>>();
            for (int i = 1; i < N; i++)
            {
                for (int j = i + 1; j <= N; j++)
                {
                    if (i + j != ngNum)
                    {
                        edge.Add(new Tuple<int, int>(i,j));
                    }
                }
            }

            WriteLine(edge.Count());
            foreach (var result in edge)
            {
                WriteLine("{0} {1}", result.Item1, result.Item2);
            }
            ReadKey();
        }
    }
}
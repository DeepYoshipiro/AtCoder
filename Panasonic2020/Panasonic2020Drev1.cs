using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace Panasonic2020
{
    class Panasonic2020Drev1
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            List<Tuple<string, int>>[] Stnd = new List<Tuple<string, int>>[N + 1];
            for (int i = 0; i <= N; i++)
            {
                Stnd[i] = new List<Tuple<string, int>>();
            }

            //"a", 1;
            Stnd[1].Add(new Tuple<string, int>("a", 1));

            string[] alpha = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j"};
            for (int i = 1; i < N; i++)
            {
                //"a", 1 → "aa", 1, "ab", 2;
                foreach (Tuple<string, int> cur in Stnd[i])
                {
                    for (int j = 0; j < cur.Item2; j++)
                    {
                        Stnd[i + 1].Add(new Tuple<string, int>(cur.Item1 + alpha[j], i));
                    }
                    Stnd[i + 1].Add(new Tuple<string, int>(cur.Item1 + alpha[cur.Item2], i + 1));
                }
            }

            foreach (Tuple<string, int> result in Stnd[N])
            {
                WriteLine(result.Item1);
            }
            ReadKey();
        }
    }
}

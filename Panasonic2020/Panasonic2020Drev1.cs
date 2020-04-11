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
            List<Tuple<string, char>>[] Stnd = new List<Tuple<string, char>>[N + 1];
            for (int i = 0; i <= N; i++)
            {
                Stnd[i] = new List<Tuple<string, char>>();
            }

            //"a", 1;
            Stnd[1].Add(new Tuple<string, char>("a", 'a'));

            for (int i = 2; i <= N; i++)
            {
                //"a", 1 → "aa", 1, "ab", 2;
                foreach (Tuple<string, char> cur in Stnd[i - 1])
                {
                    for (char j = 'a'; j <= cur.Item2; j++)
                    {
                        Stnd[i].Add(new Tuple<string, char>(cur.Item1 + j, cur.Item2));
                    }
                    char next = (char)(cur.Item2 + 1);
                    Stnd[i].Add(new Tuple<string, char>(cur.Item1 + next, next));
                }
            }

            foreach (Tuple<string, char> result in Stnd[N])
            {
                WriteLine(result.Item1);
            }
            ReadKey();
        }
    }
}

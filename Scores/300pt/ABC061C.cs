using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC061C
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int K = init[1];

            var insertDirect = new List<InsertDirection>();

            for (int i = 0; i < N; i++)
            {
                int[] info = ReadLine().Split(' ')
                    .Select(n => int.Parse(n)).ToArray();

                insertDirect.Add(new InsertDirection()
                {
                    Value = info[0], Piece = info[1]
                });
            }

            insertDirect = insertDirect.OrderBy(x => x.Value).ToList();

            int added = 0;
            int result = 0;
            for (int j = 0; j < N; j++)
            {
                added += insertDirect[j].Piece;
                if (added >= K)
                {
                    result = insertDirect[j].Value;
                    break;
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }

        class InsertDirection
        {
            public int Value
            {
                get;
                set;
            }
            public int Piece
            {
                get;
                set;
            }
        }
    }
}
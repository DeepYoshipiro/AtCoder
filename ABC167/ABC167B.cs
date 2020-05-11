using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC167
{
    class ABC167B
    {
        static void Main(string[] args)
        {
            long[] card = ReadLine().Split()
                .Select(n => long.Parse(n)).ToArray();
            long leftCard = card[3];
            long result = 0;
            long curScore = 1;
            for (int i = 0; i < 3; i++)
            {
                long drawCard = Min(card[i], leftCard);
                leftCard -= drawCard;
                result += curScore * drawCard;
                if (leftCard == 0) break;
                curScore--;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}

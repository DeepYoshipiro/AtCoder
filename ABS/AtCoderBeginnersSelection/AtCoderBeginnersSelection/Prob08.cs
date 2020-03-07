using System;
using System.Linq;
using static System.Console;

namespace AtCoderBeginnersSelection
{
    class Prob08
    {
        static void Main(string[] args)
        {
            // input
            int[] input = ReadLine().Split(' ')
                        .Select(n => int.Parse(n)).ToArray();

            int N = input[0];           //紙幣の枚数
            int Y = input[1] / 1000;    //（祖父の申告した）金額（千円単位）

            // calculate
            int[] result = { -1, -1, -1 };
            for (int i = 0; i <= N; i++)
            {
                for (int j = 0; j <= N; j++)
                {
                    int yen1000 = Y - i * 10 - j * 5;
                    if (i + j + yen1000 == N && yen1000 >= 0)
                    {
                        result[0] = i;
                        result[1] = j;
                        result[2] = yen1000;
                        break;
                    }
                }
                if (result[0] >= 0) break;
            }

            // output
            WriteLine(result[0].ToString()
                + ' ' + result[1].ToString()
                + ' ' + result[2].ToString()
                );
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC173
{
    class ABC173C
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var H = init[0];
            var W = init[1];
            var K = init[2];

            var S = new char[H][];
            int oriBlack = 0;
            for (int i = 0; i < H; i++)
            {
                S[i] = ReadLine().ToCharArray();
                oriBlack += S[i].Count(s => s == '#');
            }

            if (oriBlack < K) 
            {
                WriteLine("0");
                ReadKey();
                return;
            }

            int result = 0;
            for (int bit = 0; bit < 1 << (H + W); bit++)
            {
                for (int i = 0; i < H; i++)
                {
                    if ((bit & (1 << i)) > 0)
                    {
                        for (int j = 0; j < W; j++)
                        {
                            if (S[i][j] == '#')
                            {
                                S[i][j] = 'x';
                            }
                        }
                    }
                }

                for (int j = 0; j < W; j++)
                {
                    if ((bit & (1 << (H + j))) > 0)
                    {
                        for (int i = 0; i < H; i++)
                        {
                            if (S[i][j] == '#')
                            {
                                S[i][j] = 'x';
                            }
                        }
                    }
                }

                int Black = 0;
                for (int i = 0; i < H; i++)
                {
                    for (int j = 0; j < W; j++)
                    {
                        switch (S[i][j])
                        {
                            case 'x':
                                S[i][j] = '#';
                                break;
                            case '#':
                                Black++;
                                break;
                        }
                    }
                }
                if (Black == K) result++;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}

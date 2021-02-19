using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC191
{
    class ABC191C
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var H = init[0];
            var W = init[1];

            var S = new char[H][];

            for (int i = 0; i < H; i++)
            {
                S[i] = ReadLine().ToCharArray();
            }

            int result = 0;
            for (int j = 0; j < W - 1; j++)
            {
                bool cont = false;
                for (int i = 0; i < H - 1; i++)
                {
                    if (S[i][j] != S[i][j + 1])
                    {
                        if (!cont)
                        {
                            result++;
                            cont = true;
                        }
                    }
                    else
                    {
                        cont = false;
                    }
                }
            }

            for (int i = 0; i < H - 1; i++)
            {
                bool cont = false;
                for (int j = 1; j < W - 1; j++)
                {
                    if (S[i][j] != S[i + 1][j])
                    {
                        if (!cont)
                        {
                            result++;
                            cont = true;
                        }
                    }
                    else
                    {
                        cont = false;
                    }
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}

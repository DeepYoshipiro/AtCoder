using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace Library
{
    class DFSTest
    {
        static void Main(string[] args)
        {
            const int M = 2;
            for (int a = 0; a < M; a++)
            {
                for (int b = 0; b < M; b++)
                {
                    for (int c = 0; c < M; c++)
                    {
                        for (int d = 0; d < M; d++)
                        {
                            for (int e = 0; e < M; e++)
                            {
                                for (int f = 0; f < M; f++)
                                {
                                    for (int g = 0; g < M; g++)
                                    {
                                        for (int h = 0; h < M; h++)
                                        {
                                            for (int i = 0; i < M; i++)
                                            {
                                                for (int j = 0; j < M; j++)
                                                {
                                                    Write(a);
                                                    Write(b);
                                                    Write(c);
                                                    Write(d);
                                                    Write(e);
                                                    Write(f);
                                                    Write(g);
                                                    Write(h);
                                                    Write(i);
                                                    Write(j);
                                                    WriteLine();
                                                }
                                            }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }
            ReadKey();
        }
    }
}
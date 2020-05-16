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
            var A = new Stack<int>();
            for (int a = 0; a < M; a++)
            {
                A.Push(a);
                for (int b = 0; b < M; b++)
                {
                    A.Push(b);
                    for (int c = 0; c < M; c++)
                    {
                        A.Push(c);
                        for (int d = 0; d < M; d++)
                        {
                            A.Push(d);
                            for (int e = 0; e < M; e++)
                            {
                                A.Push(e);
                                for (int f = 0; f < M; f++)
                                {
                                    A.Push(f);
                                    for (int g = 0; g < M; g++)
                                    {
                                        A.Push(g);
                                        for (int h = 0; h < M; h++)
                                        {
                                            A.Push(h);
                                            for (int i = 0; i < M; i++)
                                            {
                                                A.Push(i);
                                                for (int j = 0; j < M; j++)
                                                {
                                                    A.Push(j);
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
                                                    A.Pop();
                                                }
                                                A.Pop();
                                            }
                                            A.Pop();
                                        }
                                        A.Pop();
                                    }
                                    A.Pop();
                                }
                                A.Pop();
                            }
                            A.Pop();
                        }
                        A.Pop();
                    }
                    A.Pop();
                }
                A.Pop();
            }
            ReadKey();
        }
    }
}
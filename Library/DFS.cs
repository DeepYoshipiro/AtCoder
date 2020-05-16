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
            var A = new List<int>();
            for (int a = 0; a < M; a++)
            {
                A.Add(a);
                for (int b = 0; b < M; b++)
                {
                    A.Add(b);
                    for (int c = 0; c < M; c++)
                    {
                        A.Add(c);
                        for (int d = 0; d < M; d++)
                        {
                            A.Add(d);
                            for (int e = 0; e < M; e++)
                            {
                                A.Add(e);
                                for (int f = 0; f < M; f++)
                                {
                                    A.Add(f);
                                    for (int g = 0; g < M; g++)
                                    {
                                        A.Add(g);
                                        for (int h = 0; h < M; h++)
                                        {
                                            A.Add(h);
                                            for (int i = 0; i < M; i++)
                                            {
                                                A.Add(i);
                                                for (int j = 0; j < M; j++)
                                                {
                                                    A.Add(j);
                                                    Writer(A.ToList());
                                                    A.RemoveAt(A.Count() - 1);
                                                }
                                                A.RemoveAt(A.Count() - 1);
                                            }
                                            A.RemoveAt(A.Count() - 1);
                                        }
                                        A.RemoveAt(A.Count() - 1);
                                    }
                                    A.RemoveAt(A.Count() - 1);
                                }
                                A.RemoveAt(A.Count() - 1);
                            }
                            A.RemoveAt(A.Count() - 1);
                        }
                        A.RemoveAt(A.Count() - 1);
                    }
                    A.RemoveAt(A.Count() - 1);
                }
                A.RemoveAt(A.Count() - 1);
            }
            ReadKey();
        }

        static void Writer(List<int> A)
        {
            foreach (int a in A)
            {
                Write(a);
            }
            WriteLine();
        }
    }
}
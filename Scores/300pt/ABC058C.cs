using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC058C
    {
        static void Main(string[] args)
        {
            int n = int.Parse(ReadLine());
            List<char>[] S = new List<char>[n];

            for (int i = 0; i < n; i++)
            {
                S[i] = ReadLine().ToList();
                S[i].Sort();
            }

            StringBuilder result = new StringBuilder();
            bool quitSearch = false;
            while (S[0].Count > 0)
            {
                bool admitAdd = true;
                bool removeFirst = true;
                for (int j = 1; j < n; j++)
                {
                    if (S[j].Count == 0)
                    {
                        quitSearch = true;
                        break;
                    }
                    if (S[0][0] != S[j][0])
                    {
                        admitAdd = false;
                        if (S[0][0] > S[j][0])
                        {
                            S[j].RemoveAt(0);
                            removeFirst = false;
                        }
                    }
                }
                if (quitSearch) break;
                if (admitAdd)
                {   
                    result.Append(S[0][0]);
                    for (int k = 0; k < n; k++)
                    {
                        S[k].RemoveAt(0);
                    }
                }
                else if (removeFirst) S[0].RemoveAt(0);
            }

            WriteLine(result);
            ReadKey();
        }
    }
}
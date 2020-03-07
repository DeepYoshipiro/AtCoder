using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Math;
using static System.Console;

namespace _300pt
{
    class ABC097C
    {
        static void Main(string[] args)
        {
            string s = ReadLine();
            int K = int.Parse(ReadLine());

            List<string> ss = new List<string>();

            for (int j = 1; j <= s.Length; j++)
            {
                //WriteLine("j = " + j);
                for (int i = 0; i < s.Length - j; i++)
                {
                    ss.Add(s.Substring(i, j));
                    //WriteLine(s.Substring(i, j));
                }
                ss = ss.Distinct().OrderBy(t => t).ToList();
                //WriteLine("ss.Count = " + ss.Count);
                if (ss.Count >= K)
                {
                    if (ss.Count > K)
                    {
                        ss.RemoveRange(K, ss.Count - K);
                    }
                    bool searched = true;
                    for (int i = 0; i < K; i++)
                    {
                        if (ss[i].Length == j) searched = false;
                    }
                    if (searched) break;
                }
            }

            WriteLine(ss[K - 1].ToString());
            ReadKey();
        }
    }
}
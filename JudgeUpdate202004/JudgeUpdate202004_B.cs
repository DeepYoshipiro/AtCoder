using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace JudgeUpdate202004
{
    class JudgeUpdate202004_B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());

            List<int> R = new List<int>();
            List<int> B = new List<int>();

            for (int i = 0; i < N; i++)
            {
                string[] op = ReadLine().Split(' ');
                if (op[1] == "R")
                {
                    R.Add(int.Parse(op[0]));
                }
                else
                {
                    B.Add(int.Parse(op[0]));
                }
            }
            R.Sort();
            B.Sort();

            for (int i = 0; i < N; i++)
            {
                if (R.Count > 0)
                {
                    WriteLine(R[0]);
                    R.RemoveAt(0);
                }
                else
                {
                    WriteLine(B[0]);
                    B.RemoveAt(0);
                }
            }
            ReadKey();
        }
    }
}

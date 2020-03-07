using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace Dwacon6thPrelims
{
    class Dwacon6thPrelimsA
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            string[] s = new string[N];
            int[] t = new int[N];
            for (int i = 0; i < N; i++)
            {
                string[] info = ReadLine().Split();
                s[i] = info[0];
                t[i] = int.Parse(info[1]);
            }
            string X = ReadLine();

            int result = 0;
            for (int i = N - 1; i >= 0; i--)
            {
                if (s[i].Equals(X))
                {
                    break;
                }
                else
                {
                    result += t[i];
                }
            }
            Console.WriteLine(result.ToString());
            ReadKey();
        }
    }
}

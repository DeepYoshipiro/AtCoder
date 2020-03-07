using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _200pt
{
    class ABC136B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());

            int result = 0;
            for (int i = 1; i <= 9; i++)
            {
                if (i <= N) result++;
                else break;
            }

            if (N < 100)
            {
                WriteLine(result.ToString());
                ReadKey();
                return;
            }

            for (int i = 100; i <= 999; i++)
            {
                if (i <= N) result++;
            }

            if (N < 10000)
            {
                WriteLine(result.ToString());
                ReadKey();
                return;
            }

            for (int i = 10000; i <= 99999; i++)
            {
                if (i <= N) result++;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
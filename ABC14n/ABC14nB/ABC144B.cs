using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC144
{
    class ABC144B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());

            bool result = false;
            for (int i = 1; i <= Min(N, 9); i++)
            {
                if (N % i == 0 && N / i < 10)
                {
                    result = true;
                    break;
                }
            }

            WriteLine(result ? "Yes" : "No");
            ReadKey();
        }
    }
}

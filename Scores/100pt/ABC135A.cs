using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _100pt
{
    class ABC135A
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
          	int A = init[0];
          	int B = init[1];

			int K = (A + B) / 2;
          	if (Abs(A - K) == Abs(B - K))
	            WriteLine(K.ToString());
          	else
              	WriteLine("IMPOSSIBLE");
            ReadKey();
        }
    }
}

using System;
using System.Linq;
using static System.Console;
using static System.Math;

namespace _200pt
{

    class ABC120B
    {
        static void Main(string[] args)
        {
            //input
            int[] input = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int A = input[0];
            int B = input[1];
            int K = input[2];

            //calculate
            int minAB = Min(A, B);
            int dividedAB = 0;
            int result = 0;
            for (int i = minAB; i >= 1; i--)
            {
                if (A % i == 0 && B % i == 0)
                {
                    if (++dividedAB == K)
                    {
                        result = i;
                        break;
                    }
                }
            }

            //output
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}

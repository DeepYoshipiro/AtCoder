using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace AISing2020
{
    class AISing2020C
    {
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());

            for (int n = 1; n <= N; n++)
            {
                int result = 0;
                for (int x = 1; x * x <= N; x++)
                {
                    int restY = N - x * x;
                    for (int y = x; y * y <= restY; y++)
                    {
                        int restZ = restY - x * y + y * y;
                        var restZdivide = (new DiscreteMath()).Divisor(restZ);
                        foreach (long z in restZdivide)
                        {
                            if (z * (z + y + x) == n)
                            {
                                if (x == y && y == z) result++;
                                else if (x == y || y == z) result += 3;
                                else result += 6;
                            }
                        }
                        // for (int z = y; z * z <= restZ; z++)
                        // {
                        //     if (x * x + y * y + z * z + x * y + y * z + z * x == n)
                        //     {
                        //         if (x == y && y ==z) result++;
                        //         else if (x == y || y == z) result += 3;
                        //         else result += 6;
                        //     } 
                        // }
                    }
                }
                //WriteLine(result.ToString());
            }
            WriteLine("Ready!");
            ReadKey();
        }
    }

    class DiscreteMath
    {
        internal IEnumerable<long> Divisor(long N)
        {
            for (int i = 1; i * i <= N; i++)
            {
                if (N % i == 0)
                {
                    yield return i;
                    if (i * i != N) yield return N / i;
                }
            }
            yield break;
        }
    }
}

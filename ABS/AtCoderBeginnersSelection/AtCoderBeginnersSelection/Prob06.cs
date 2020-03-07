using System;
using System.Linq;
using static System.Console;

namespace AtCoderBeginnersSelection
{
    class Prob06
    {
        static void Main(string[] args)
        {
            // input
            int N = int.Parse(ReadLine());
            int[] A = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).OrderByDescending(m => m).ToArray();

            // calculate
            int result = 0;

            
            for (int i = 0; i < N; i++)
            {
                if (i % 2 == 0)
                    result += A[i];     // Aliceの得点加算
                else
                    result -= A[i];     // Bobの得点減算
            }

            // output
            WriteLine(result);
        }
    }
}

using System;
using System.Linq;
using static System.Math;

namespace _200pt
{
    class ABC102B
    {
        static void Main(string[] args)
        {
            //input
            int N = int.Parse(Console.ReadLine());
            int[] A = Console.ReadLine().Split(' ')
                        .Select(n => int.Parse(n)).ToArray();

            //calculate
            int maxAbsDiff = 0;
            for (int i = 0; i < N; i++) {
                for (int j = i + 1; j < N; j++) {
                    int Diff = Abs(A[i] - A[j]);
                    if (Diff > maxAbsDiff) maxAbsDiff = Diff;
                }
            }
            //output
            Console.WriteLine(maxAbsDiff.ToString());
            Console.ReadKey();
        }
    }
}

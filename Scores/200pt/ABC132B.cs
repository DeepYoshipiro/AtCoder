using System;
using System.Linq;
using static System.Console;

namespace _200pt
{
    class ABC134B
    {
        static void Main(string[] args)
        {
            //input
            int n = int.Parse(ReadLine());
            int[] permutation = ReadLine().Split(' ').Select(m => int.Parse(m)).ToArray();

            //calculate
            int result = 0;
            for (int i = 0; i < n - 2; i++)
            {
                int[] permu = { permutation[i], permutation[i + 1], permutation[i + 2] };
                int centerNum = permutation[i + 1];

                Array.Sort(permu);

                if (centerNum == permu[1]) result++;
            }

            //output;
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}

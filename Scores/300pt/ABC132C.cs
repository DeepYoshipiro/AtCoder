using System;
using System.Linq;
using static System.Console;

namespace _300pt
{

    class ABC132C
    {
        static void Main(string[] args)
        {
            //input
            int N = int.Parse(ReadLine());
            int[] d = ReadLine().Split(' ')
                .Select(n => int.Parse(n))
                .OrderBy(n => n).ToArray();

            //calculate
            int minARC = d[N / 2];
            int maxABC = d[N / 2 - 1];
            int result = minARC - maxABC;

            //output;
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}

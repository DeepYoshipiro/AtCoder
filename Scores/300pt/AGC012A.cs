using System;
using static System.Console;
using System.Linq;
using static System.Math;

namespace _300pt
{
    class AGC012A
    {
        static void Main(string[] args)
        {
            //input
            int N = int.Parse(ReadLine());
            int[] a = ReadLine().Split(' ').Select(n=> int.Parse(n))
                .OrderByDescending(m => m).ToArray();

            //calculate
            long result = 0;
            for (int i = 0; i < N; i++){
                result += a[2* i + 1];
            }

            //output;
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}

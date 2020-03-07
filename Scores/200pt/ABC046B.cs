using System;
using System.Linq;

namespace _200pt
{
    class ABC046B
    {
        static void Main(string[] args)
        {
            //input
            int[] input = Console.ReadLine().Split(' ')
                        .Select(n => int.Parse(n)).ToArray();
            int N = input[0];   //ボール
            int K = input[1];   //色の数

            //calculate
            int result = K * (int)Math.Pow(K - 1, N - 1);

            Console.WriteLine(result.ToString());
            Console.ReadKey();
        }
    }
}

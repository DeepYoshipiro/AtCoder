using System;
using System.Linq;

namespace abc138
{
    class abc138b
    {
        static void Main(string[] args)
        {
            // input
            int N = int.Parse(Console.ReadLine());
            decimal[] Ai = Console.ReadLine().Split(' ').Select(d => decimal.Parse(d)).ToArray();
            decimal Reverse = 0;

            // calculate
            for (int i = 0; i < N; i++)
            {
                Reverse += 1 / Ai[i];
            }

            // output
            decimal Result = 1 / Reverse;   // 2回逆数を取ったものが答えなので
            Console.WriteLine(Result);
        }
    }
}

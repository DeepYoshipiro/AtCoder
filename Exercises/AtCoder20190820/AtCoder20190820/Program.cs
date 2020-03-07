using System;
using System.Linq;

namespace AtCoder20190820
{
    class DISCO_presents_ディスカバリーチャンネル_コードコンテスト2017_予選_B
    {
        static void Main(string[] args)
        {
            //input
            int[] input = Console.ReadLine().Split(' ')
                    .Select(n => int.Parse(n)).ToArray();

            int A = input[0];
            int B = input[1];
            int C = input[2];
            int D = input[3];

            //output
            int result = A * 12 * 12 * 12 + B * 12 * 12 + C * 12 + D;
            Console.WriteLine(result);
        }
    }
}

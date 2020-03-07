using System;
using System.Linq;
using System.Collections.Generic;

namespace _200pt
{
 
    class ABC093B
    {
        static void Main(string[] args)
        {
            //input
            int[] input = Console.ReadLine().Split(' ')
                        .Select(n => int.Parse(n)).ToArray();
            int A = input[0];   //A以上
            int B = input[1];   //B以下
            int K = input[2];   //小さい方から、大きい方からK番目以内


            //calculate
            SortedSet<int> result = new SortedSet<int>();

            for (int k = 0; k < K; k++)
            {
                if (B - k < A || A + k > B) break;
                result.Add(A + k);
                result.Add(B - k);
            }

            foreach (int res in result)
            {
                Console.WriteLine(res.ToString());
            }
            Console.ReadKey();
        }
    }
}

using System;
using System.Linq;

namespace _200pt
{
    class ABC078B
    {
        static void Main(string[] args)
        {
            //input
            decimal[] input = Console.ReadLine().Split(' ')
                        .Select(n => decimal.Parse(n)).ToArray();
            decimal X = input[0];
            decimal Y = input[1];
            decimal Z = input[2];


            //calculate
            int result = (int)(Math.Floor((X - Z) / (Y + Z)));

            Console.WriteLine(result.ToString());
            Console.ReadKey();
        }
    }
}

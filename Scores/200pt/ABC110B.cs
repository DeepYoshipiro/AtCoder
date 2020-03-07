using System;
using System.Linq;

namespace _200pt
{
    class ABC110B
    {
        static void Main(string[] args)
        {
            //input
            int[] input = Console.ReadLine().Split(' ')
                        .Select(n => int.Parse(n)).ToArray();
            int N = input[0];
            int M = input[1];
            int X = input[2];
            int Y = input[3];

            int[] x = Console.ReadLine().Split(' ')
                        .Select(n => int.Parse(n)).ToArray();
            int xmax = x.Max();
            xmax = (xmax > X ? xmax : X);

            int[] y = Console.ReadLine().Split(' ')
                        .Select(n => int.Parse(n)).ToArray();
            int ymin = y.Min();
            ymin = (ymin < Y ? ymin : Y);

            //calculate & output
            if (xmax >= ymin)
            {
                Console.WriteLine("War");
            }
            else {
                Console.WriteLine("No War");
            }

            Console.ReadKey();
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ARC106
{
    class ARC106C
    {
        class Segment
        {
            internal int L{get;}
            internal int R{get;}

            internal Segment(int l, int r)
            {
                L = l;
                R = r;
            }
        }
        static void Main(string[] args)
        {
            // var N = int.Parse(ReadLine());
            var L = new int[]{15, 30, 27, 14, 21, 6, 9, 1, 12, 2};
            var R = new int[]{29, 32, 47, 19, 38, 34, 43, 7, 16, 20};
            var segment = new Segment[10];
            for (int i = 0; i < 10; i++)
            {
                segment[i] = new Segment(L[i], R[i]);
            }

            // Takahashi's Program
            // var Tsegment = segment.OrderByDescending((int L, int R) => r).ToArray();

            // var init = ReadLine().Split()
            //     .Select(n => int.Parse(n)).ToArray();
            // var N = init[0];
            // var M = init[1];

            // var N = long.Parse(ReadLine());
            // var init = ReadLine().Split()
            //     .Select(n => long.Parse(n)).ToArray();

            // var S = ReadLine().ToCharArray();
            // var S = ReadLine();
            // var S = ReadLine().ToArray();

            WriteLine("Hello World!");
            ReadKey();
        }
    }
}

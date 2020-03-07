using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ABC089D
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int H = init[0];
            int W = init[1];
            int D = init[2];

            int[] numPosH = new int[H * W + 1];
            int[] numPosW = new int[H * W + 1];

            for (int h = 0; h < H; h++)
            {
                int[] A = ReadLine().Split(' ')
                    .Select(n => int.Parse(n)).ToArray();
                
                for (int w = 0; w < W; w++)
                {
                    numPosH[A[w]] = h;
                    numPosW[A[w]] = w;
                }
            }
            
            int Q = int.Parse(ReadLine());
            int[] L = new int[Q];
            int[] R = new int[Q];
            for (int q = 0; q < Q; q++)
            {
                int[] exam = ReadLine().Split(' ')
                    .Select(n => int.Parse(n)).ToArray();

                L[q] = exam[0];
                R[q] = exam[1];
            }

            for (int q = 0; q < Q; q++)
            {
                long move = 0;
                for (int p = L[q]; p < R[q]; p += D)
                {
                    move += Abs(numPosH[p + D] - numPosH[p]);
                    move += Abs(numPosW[p + D] - numPosW[p]);
                }
                WriteLine(move.ToString());
            }
            ReadKey();
        }
    }
}

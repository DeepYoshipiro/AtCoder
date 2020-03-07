using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC146
{
    class ABC146F
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                    .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int M = init[1];

            char[] S = ReadLine().ToCharArray();

            bool clearAble = false;
            int location = N;
            Stack<int> order = new Stack<int>();
            while (location > 0)
            {
                clearAble = false;
                for (int m = Min(M, location); m >= 1; m--)
                {
                    if (S[location - m].Equals('0'))
                    {
                        order.Push(m);
                        location -= m;
                        clearAble = true;
                        break;
                    }
                }
                if (!clearAble) break;
            }
 
            if (clearAble)
            {
                while (order.Count > 0)
                {
                    Write(order.Pop().ToString() + " ");
                }
            }
            else
            {
                WriteLine("-1");
            }

            ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC144
{
    class ABC144A
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int A = init[0];
            int B = init[1];

            if (A >= 10 || B >= 10)
            {
                WriteLine("-1");
                ReadKey();
                return;
            }
            
            WriteLine(A * B);
            ReadKey();
        }
    }
}

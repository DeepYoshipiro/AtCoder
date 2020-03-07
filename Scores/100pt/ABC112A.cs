using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _100pt
{
    class ABC112A
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            if (N == 1)
            {
                WriteLine("Hello World");
                ReadKey();
                return;
            }

            int A = int.Parse(ReadLine());
            int B = int.Parse(ReadLine());

            WriteLine(A + B);
            ReadKey();
        }
    }
}

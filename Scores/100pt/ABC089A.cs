using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _100pt
{
    class ABC089A
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());

            int result = N / 3;
            
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}

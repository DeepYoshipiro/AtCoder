using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _200pt
{
    class ABC064B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            int[] a = Console.ReadLine().Split(' ')
                        .Select(n => int.Parse(n))
                        .OrderBy(n => n).ToArray();
            
            WriteLine((a.Last() - a.First()).ToString());
            ReadKey();
        }
    }
}
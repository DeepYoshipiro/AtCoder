using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC193
{
    class ABC193C
    {
        static void Main(string[] args)
        {
            var N = long.Parse(ReadLine());
            var appearAble = new HashSet<long>();
            for (long i = 2; i * i <= N; i++)
            {
                var curI = i * i;
                while (curI <= N)
                {
                    appearAble.Add(curI);
                    curI *= i; 
                }
            }

            var result = N - appearAble.LongCount();
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC187
{
    class ABC187B
    {
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());

            var x = new int[N];
            var y = new int[N];
            for (int i = 0; i < N; i++)
            {
                var p = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                x[i] = p[0];
                y[i] = p[1];
            }

            int result = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    var diffY = Abs(y[j] - y[i]);
                    var diffX = Abs(x[j] - x[i]);
                    if (diffY <= diffX) 
                        result++;
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}

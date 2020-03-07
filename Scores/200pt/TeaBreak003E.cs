using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace TeaBreak003
{
    class TeaBreak003E
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            double[] m = new double[N];
            for (int i = 0; i < N; i++)
            {
                double[] point = Console.ReadLine().Split(' ')
                        .Select(w => double.Parse(w)).ToArray();
                double x = point[0];
                double y = point[1];
                if (x == 0)
                {
                    m[i] = double.MaxValue;
                }
                else
                {
                    m[i] = y / x;
                }
            }

            int result = 1;
            Array.Sort(m);

            double cur = m[0];
            int continuous = 1;
            for (int i = 1; i < N; i++)
            {
                if (cur == m[i])
                {
                    continuous++;
                    if (continuous > result) 
                        result = continuous;
                }
                else
                {
                    continuous = 1;
                    cur = m[i];
                }

            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
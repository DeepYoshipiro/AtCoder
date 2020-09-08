using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _500pt
{
    class ABC131E
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var N = init[0];
            var K = init[1];

            if (K > (N - 2) * (N - 1) / 2
                || (N == 2 && K == 1)
                )
            {
                WriteLine("-1");
                ReadKey();
                return;
            }

            var result = new List<string>(); 
            for (int i = 1; i < N; i++)
            {
                result.Add(i.ToString() + " " + N.ToString());
            }

            int leftK = K;
            for (int i = 1; i < N; i++)
            {
                for (int j = i + 1; j < N; j++)
                {
                    if (leftK > 0)
                    {
                        leftK--;
                    }
                    else
                    {
                        result.Add(i.ToString() + " " + j.ToString());
                    }
                }
            }

            WriteLine(result.Count().ToString());
            foreach (string way in result)
            {
                WriteLine(way);
            }
            ReadKey();
        }
    }
}

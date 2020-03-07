using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC116C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            int[] h = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();

            List<int> purposeHeight =
                h.Distinct().OrderBy(n => n).ToList();

            int nowMaxHeight = 0;
            int island = 1;
            int result = 0;

            while (purposeHeight.Count >= 1)
            {
                result += 
                    island * (purposeHeight[0] - nowMaxHeight);
                nowMaxHeight = purposeHeight[0];

                island = 0;
                bool connected = false;
                for (int i = 0; i < N; i++)
                {
                    if (h[i] > nowMaxHeight)
                    {
                        if (!connected) 
                        {
                            island++;
                        }
                        connected = true;
                    }
                    else
                    {
                        connected = false;
                    }
                }

                purposeHeight.RemoveAt(0);
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}

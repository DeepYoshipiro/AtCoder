using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ABC091C
    {
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());
            var RedMax = new List<int>();
            for (int i = 0; i < N; i++)
            {
                var redPoint = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                RedMax.Add(redPoint.Max());
            }
            RedMax.Sort();

            var BlueMin = new List<int>();
            for (int i = 0; i < N; i++)
            {
                var bluePoint = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                BlueMin.Add(bluePoint.Min());
            }
            BlueMin.Sort();

            int result = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < BlueMin.Count(); j++)
                {
                    if (RedMax[i] <= BlueMin[j])
                    {
                        result++;
                        BlueMin.RemoveAt(j);             
                        break;
                    }
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
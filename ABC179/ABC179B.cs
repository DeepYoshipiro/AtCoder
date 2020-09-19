using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC179
{
    class ABC179B
    {
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());

            int doublet = 0;
            bool result = false;
            for (int i = 0; i < N; i++)
            {
                var diceThrow = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                
                if (diceThrow[0] == diceThrow[1])
                {
                    doublet++;
                    if (doublet == 3) result = true;
                }
                else
                {
                    doublet = 0;
                }
            }

            WriteLine(result ? "Yes" : "No");
            ReadKey();
        }
    }
}

using System;
using System.Linq;
using static System.Console;

namespace _200pt
{

    class ABC112B
    {
        static void Main(string[] args)
        {
            const int MAX_COST = 1000;
            //input & calculate
            int[] input = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();

            int route = input[0];
            int timeLimit = input[1];

            int minCost = MAX_COST + 1;

            for (int i = 0; i < route; i++)
            {
                int[] wayInfo = ReadLine().Split(' ')
                    .Select(n => int.Parse(n)).ToArray();

                int cost = wayInfo[0];
                int time = wayInfo[1];

                if (time <= timeLimit && cost < minCost) { minCost = cost; }
            }

            //output
            if (minCost <= MAX_COST)
                WriteLine(minCost.ToString());
            else
                WriteLine("TLE");

            ReadKey();
        }
    }
}

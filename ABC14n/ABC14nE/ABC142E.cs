using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC142
{
    class ABC142E
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int M = init[1];

            int[] price = new int[M];
            int[] openableChest = new int[M];
            for (int i = 0; i < M; i++)
            {
                int[] info = ReadLine().Split(' ')
                    .Select(n => int.Parse(n)).ToArray();
                price[i] = info[0];
                int b = info[1];

                int[] chestInfo = ReadLine().Split(' ')
                    .Select(n => int.Parse(n)).ToArray();
                openableChest[i] = 0;
                for (int j = 0; j < b; j++)
                {
                    openableChest[i] += 1 << (chestInfo[j] - 1);
                }
            }

            int[] dpCost = (new int[1 << N])
                    .Select(n => int.MaxValue).ToArray();
            dpCost[0] = 0;

            HashSet<int> opened = new HashSet<int>();
            opened.Add(0);

            for (int j = 0; j < M; j++){
                HashSet<int> newOpen = new HashSet<int>();
                foreach (int i in opened){
                    dpCost[i | openableChest[j]]
                     = Min(dpCost[i | openableChest[j]]
                        , dpCost[i] + price[j]);
                    newOpen.Add(i | openableChest[j]);
                }
                opened.UnionWith(newOpen);
            }

            int result = dpCost[(1 << N) - 1];
            if (result == int.MaxValue) result = -1;

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
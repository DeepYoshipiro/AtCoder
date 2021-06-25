using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC176
{
    class ABC176E
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var H = init[0];
            var W = init[1];
            var M = init[2];

            var targetCntH = new int[H + 1];
            var targetCntW = new int[W + 1];

            int maxTargetCntH = 0;
            int maxTargetCntW = 0;   
            var TargetPos = new HashSet<long>();
            for (int i = 0; i < M; i++)
            {
                var info = ReadLine().Split()
                    .Select(n => long.Parse(n)).ToArray();
                var h = info[0];
                var w = info[1];

                targetCntH[h]++;
                if (maxTargetCntH < targetCntH[h])
                    maxTargetCntH = targetCntH[h];

                targetCntW[w]++;
                if (maxTargetCntW < targetCntW[w])
                    maxTargetCntW = targetCntW[w];
                
                TargetPos.Add((h - 1) * (long)W + w);
            }

            var maxTargetH = new List<int>();
            for (int j = 1; j <= H; j++)
            {
                if (maxTargetCntH == targetCntH[j])
                    maxTargetH.Add(j);
            }

            var maxTargetW = new List<int>();
            for (int k = 1; k <= W; k++)
            {
                if (maxTargetCntW == targetCntW[k])
                    maxTargetW.Add(k);
            }
            
            var putAllBombPosExistTarget = true;
            for (int j = 0; j < maxTargetH.Count(); j++)
            {
                for (int k = 0; k < maxTargetW.Count(); k++)
                {
                    if (!TargetPos.Contains((maxTargetH[j] - 1) * (long)W + maxTargetW[k]))
                    {
                        putAllBombPosExistTarget = false;
                        break;
                    }
                }
                if (!putAllBombPosExistTarget) break;
            }

            var result = maxTargetCntH + maxTargetCntW
                - (putAllBombPosExistTarget ? 1 : 0);
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}

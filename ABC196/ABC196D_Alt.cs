// Solition : bit Search
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC196
{
    class ABC196D_Alt
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var H = init[0];
            var W = init[1];
            var A = init[2];
            var B = init[3];

            var maxHthreshold = (H - 1) * W;
            var maxWthreshold = H * (W - 1);

            int result = 0;
            for (int bit = 0; bit < 1 << (maxHthreshold + maxWthreshold); bit++)
            {
                var WideTatamiCnt = StandBitCnt(bit, maxHthreshold + maxWthreshold);
                if (WideTatamiCnt != A) continue;

                var cellWideTatamiCnt = new int[H][]
                        .Select(v => new int[W]).ToArray();

                var infoH = bit & ((1 << maxHthreshold) - 1);
                for (int i = 0; i < H - 1; i++)
                {
                    for (int j = 0; j < W; j++)
                    {
                        var Wide = infoH & 1;
                        cellWideTatamiCnt[i][j] += Wide;
                        cellWideTatamiCnt[i + 1][j] += Wide;
                        infoH >>= 1;
                    }
                }

                var infoW = bit >> maxHthreshold;
                for (int i = 0; i < H; i++)
                {
                    for (int j = 0; j < W - 1; j++)
                    {
                        var Wide = infoW & 1;
                        cellWideTatamiCnt[i][j] += Wide;
                        cellWideTatamiCnt[i][j + 1] += Wide;
                        infoW >>= 1;
                    }
                }

                var paved = true;
                for (int i = 0; i < H; i++)
                {
                    for (int j = 0; j < W; j++)
                    {
                        if (cellWideTatamiCnt[i][j] >= 2)
                        {
                            paved = false;
                            break;
                        } 
                    }
                    if (!paved) break;
                }

                if (paved) result++;
            }

            WriteLine(result.ToString());
            ReadKey();
        }

        static int StandBitCnt(int bit, int digit)
        {
            int result = 0;
            for (int i = 0; i < digit; i++)
            {
                result += (bit >> i) & 1;
            }
            return result; 
        }
    }
}

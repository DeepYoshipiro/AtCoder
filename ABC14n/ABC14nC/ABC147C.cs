// Solution : bit Search
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC147
{
    class ABC147C
    {
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());
            var testimony = new Dictionary<int, int>[N + 1]
                .Select(v => new Dictionary<int, int>())
                .ToArray();
            for (int i = 1; i <= N; i++)
            {
                int A = int.Parse(ReadLine());
                for (int j = 1; j <= A; j++)
                {
                    var said = ReadLine().Split()
                        .Select(n => int.Parse(n)).ToArray();
                    var x = said[0];
                    var y = said[1];
                    testimony[i].Add(x, y);
                }
            }

            int result = 0;
            for (int bit = 0; bit < (1<<N); bit++)
            {
                bool truth = true;
                for (int i = 1; i <= N; i++)
                {
                    if ((bit & 1<<(i-1)) != 0)
                    {
                        foreach (KeyValuePair<int, int> test in testimony[i])
                        {
                            if ((bit & 1<<(test.Key - 1)) !=(test.Value<<(test.Key - 1)))
                            {
                                truth = false;
                                break;
                            }
                        }
                        if (!truth) break;
                    }
                }
                if (truth)
                {
                    int honest = 0;
                    for (int i = 1; i <= N; i++)
                    {
                        if ((bit & 1<<(i-1)) != 0)
                        {
                            honest++;
                        }
                    }
                    if (honest > result) result = honest;
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ZONe2021
{
    class ZONe2021ex3
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var N = init[0];
            var M = init[1];

            var interaction = new bool[N][]
                .Select(v => new bool[N]).ToArray();
            for (int j = 0; j < M; j++)
            {
                var star = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                interaction[star[0]][star[1]] = true;
                interaction[star[1]][star[0]] = true;
            }

            var learned = new bool[N];
            // var dic = new Dictionary<int, int>();
            var connect = new int[N];
            for (int i = 0; i < N; i++)
            {
                // var connect = 0;
                for (int j = 0; j < N; j++)
                {
                    connect[i] += interaction[i][j] ? 1 : 0; 
                }
                // dic.Add(i, connect);
            }

            var result = new List<int>(3);
            var mastered = 0;
            for (int s = 0; s < 3; s++)
            {
                var learnLang = connect.Max();
                int targetStar = -1;
                for (int i = 0; i < N; i++)
                {
                    if (!learned[i] && connect[i] == learnLang)
                    {
                        targetStar = i;
                        result.Add(i);
                        break;
                    }
                }

                learned[targetStar] = true;
                mastered++;
                for (int next = 0; next < N; next++)
                {
                    if (!learned[next] && interaction[targetStar][next]) 
                    {
                        mastered++;
                        learned[next] = true; 
                        for (int next2 = 0; next2 < N; next2++)
                        {
                            if (!interaction[next][next2]) continue;
                            interaction[next][next2] = false;
                            interaction[next2][next] = false;;
                            connect[next]--;
                            connect[next2]--;
                        }
                        for (int i = 0; i < N; i++)
                        {
                            if (!interaction[next][i]) continue;
                            interaction[next][i] = false;
                            interaction[i][next] = false;
                            connect[i]--;
                            connect[next]--;
                        }
                        // interaction[next].Clear();
                        // connect.Remove(next);
                    }
                }
                // interaction[targetStar].Clear();
                // for (int i = 0; i < N; i++)
                // {
                //     if (!interaction[targetStar][i]) continue;
                //     interaction[targetStar][i] = false;
                //     interaction[i][targetStar] = false;
                //     connect[i]--;
                //     connect[targetStar]--;
                // }
                // connect.Remove(targetStar);
            }

            result.Sort();
            WriteLine("{0} {1} {2}", result[0], result[1], result[2]);
            ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC157
{
    class ABC157D
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
            var N = init[0];
            var M = init[1];
            var K = init[2];
            
            var friend = new List<int>[N + 1];
            for (int j = 1; j <= N; j++)
            {
                friend[j] = new List<int>();
            } 

            var uf = new Union_Find(N);
            for (int i = 0; i < M; i++)
            {
                var like = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                var x = like[0];
                var y = like[1];
                
                friend[x].Add(y);
                friend[y].Add(x);

                uf.Union(x, y);
            }

            var groupMemberCnt = new int[N + 1];
            var friendCandidateCnt = new int[N + 1];
            for (int j = 1; j <= N; j++)
            {
                uf.Root(j);
            }
            
            for (int j = 1; j <= N; j++)
            {
                groupMemberCnt[uf.Parent[j]]++;
            }
            
            for (int j = 1; j <= N; j++)
            {
                if (j != uf.Parent[j])
                {
                    groupMemberCnt[j]
                     = groupMemberCnt[uf.Parent[j]];
                }
                friendCandidateCnt[j] = groupMemberCnt[j] - 1;
                friendCandidateCnt[j] -= friend[j].Count();
            }

            for (int i = 0; i < K; i++)
            {
                var block = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                var x = block[0];
                var y = block[1];

                if (uf.Parent[x] == uf.Parent[y])
                { 
                    friendCandidateCnt[x]--;
                    friendCandidateCnt[y]--;
                }                    
            }

            for (int j = 1; j <= N; j++)
            {
                Write(friendCandidateCnt[j] + " ");
            }
            WriteLine();
            ReadKey();
        }
    }

    internal class Union_Find
    {
        internal int[] Parent;
        internal Union_Find(int N)
        {
            Parent = new int[N + 1];
            for (int i = 1; i <= N; i++)
            {
                Parent[i] = i;
            }
        }

        internal void Union(int x, int y)
        {
            int p = Root(x);
            int q = Root(y);

            if (p == q) return;
            Parent[q] = p;
            Parent[y] = p;

            return;  
        }

        internal int Root(int x)
        {
            if (x == Parent[x]) return x;
            return Parent[x] = Root(Parent[x]);
        }
    }
}



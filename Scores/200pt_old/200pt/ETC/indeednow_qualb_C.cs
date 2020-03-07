using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace ETC
{
    class indeednow_qualb_C
    {
        static int N;
        static List<int>[] vertex;

        static void Main(string[] args)
        {
            N = int.Parse(ReadLine());
            
            vertex = new List<int>[N + 1];
            for (int i = 0; i <= N; i++)
            {
                vertex[i] = new List<int>();
            }

            for (int i = 1; i <= N - 1; i++)
            {
                int[] node
                    = ReadLine().Split(' ')
                     .Select(n => int.Parse(n)).ToArray();
                
                vertex[node[0]].Add(node[1]);                
                vertex[node[1]].Add(node[0]);                
            }

            for (int i = 1; i <= N; i++)
            {
                vertex[i].Sort();
            }

            HashSet<int> visited = new HashSet<int>{1};
            List<int> pending = new List<int>();
            dfs(1, 0, visited);

            StringBuilder result = new StringBuilder();
            foreach (int i in visited)
            {
                result.Append(i.ToString());
                result.Append(" ");
            }

            WriteLine(result.ToString().TrimEnd(' '));
            ReadKey();
        }

        static void dfs(int current, int parent, HashSet<int> visited)
        {
            if (visited.Count == N) return;
            foreach (int i in vertex[current])
            {
                if (i == parent) continue;
                visited.Add(i);
                dfs(i, current, visited);
            }
        }
    }
}
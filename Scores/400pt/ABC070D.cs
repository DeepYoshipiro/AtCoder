using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ABC070D
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());

            List<Node>[] node = new List<Node>[N + 1];
            for (int i = 0; i <= N; i++)
            {
                node[i] = new List<Node>();
            }

            for (int i = 0; i < N - 1; i++)
            {
                long[] info = ReadLine().Split()
                    .Select(m => long.Parse(m)).ToArray();
                int a = (int)info[0];
                int b = (int)info[1];
                long c = info[2];

                node[a].Add(new Node(b, c));
                node[b].Add(new Node(a, c));
            }

            int[] que = ReadLine().Split()
                    .Select(m => int.Parse(m)).ToArray();
            int Q = que[0];
            int K = que[1];

            long[] distance = new long[N + 1];
            for (int i = 0; i <= N; i++)
            {
                distance[i] = long.MaxValue;
            }

            bool[] arrived = new bool[N + 1];
            Queue<int> search = new Queue<int>();
            search.Enqueue(K);
            distance[K] = 0;
            while (search.Count > 0)
            {
                int cur = search.Dequeue();
                if (arrived[cur]) continue;
                arrived[cur] = true;
                foreach (Node nd in node[cur])
                {
                    if (arrived[nd.to]) continue;
                    if (distance[nd.to] > distance[cur] + nd.dist)
                    {
                        distance[nd.to] = distance[cur] + nd.dist;
                    }
//                    arrived[nd.to] = true;
                    search.Enqueue(nd.to);
                }                
            }

            long[] result = new long[Q];
            for (int j = 0; j < Q; j++)
            {
                int[] point = ReadLine().Split()
                    .Select(m => int.Parse(m)).ToArray();
                result[j] = distance[point[0]] + distance[point[1]];
            }

            for (int j = 0; j < Q; j++)
            {
                WriteLine(result[j].ToString());
            }
            ReadKey();
        }

        internal class Node
        {
            public int to {get; set;}
            public long dist {get; set;}

            public Node(int to, long dist)
            {
                this.to = to;
                this.dist = dist;
            }
        }
    }
}

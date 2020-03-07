using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class YuruFuwa3_2F
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());

            List<Edge>[] edge = new List<Edge>[N + 1];
            for (int i = 1; i <= N; i++)
            {
                edge[i] = new List<Edge>();
            }

            for (int i = 0; i < N - 1; i++)
            {
                long[] info = ReadLine().Split()
                    .Select(n => long.Parse(n)).ToArray();

                int from = (int)info[0];
                int to = (int)info[1];
                long value = info[2];
                edge[from].Add(new Edge(i, to, value));                
                edge[to].Add(new Edge(i, from, value));                
            }

        }
    }

    class Edge
    {
        public int id {get;}
        public int to {get;}
        public long value {get;}

        public Edge(int _id, int _to, long _value)
        {
            id = _id;
            to = _to;
            value = _value;
        }
    }
}
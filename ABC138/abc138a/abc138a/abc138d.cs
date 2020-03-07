using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;

namespace abc138
{
    class abc138d
    {
        static void Main(string[] args)
        {
            // input & calculate
            int[] inputLine1 = ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();
            int N = inputLine1[0];
            int Q = inputLine1[1];

            // グラフ情報の読み込み、設定
            Vertex[] vertex = new Vertex[N + 1];
            for (int i = 1; i <= N; i++) {
                vertex[i] = new Vertex();
            }

            for (int i = 0; i < N - 1; i++)
            {
                int[] edge = Console.ReadLine().Split(' ').Select(m => int.Parse(m)).ToArray();
                vertex[edge[0]].AddChildVertex(edge[1]);
                vertex[edge[1]].AddChildVertex(edge[0]);
            }

            // グラフの頂点にだけ、加算値を加える。
            for (int j = 0; j < Q; j++)
            {
                int[] suggestion = Console.ReadLine().Split(' ').Select(m => int.Parse(m)).ToArray();
                int addElement = suggestion[0];
                int addValue = suggestion[1];

                vertex[addElement].AddValue(addValue);
            }

            dfs(1, 0, vertex);

            // output
            StringBuilder result = new StringBuilder();
            for (int k = 1; k <= N; k++) {
                result.Append(vertex[k].GetValue().ToString() + " ");
            }

            result.Remove(result.Length - 1, 1);

            WriteLine(result);
            ReadKey();
        }

        static void dfs(int i, int parent, Vertex[] vertex)
        {
            int parentValue = vertex[i].GetValue(); 
            foreach (int j in vertex[i].getChildVertex())
            {
                if (j == parent) continue;
                vertex[j].AddValue(parentValue);
                dfs(j, i, vertex);
            }            
        }
    }

    class Vertex
    {
        int Value = 0;
        private HashSet<int> ChildVertex = new HashSet<int>();

        internal Vertex() {
        }

        internal void AddChildVertex(int index)
        {
            ChildVertex.Add(index);
        }

        internal void AddValue(int value)
        {
            Value += value;
        }

        internal int GetValue()
        {
            return Value;
        }

        internal HashSet<int> getChildVertex()
        {
            return ChildVertex;
        }
    }
}
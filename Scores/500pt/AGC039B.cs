using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _500pt
{
    class AGC039B
    {
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());
            var edge = new List<int>[N]; 
            for (int i = 0; i < N; i++)
            {
                edge[i] = new List<int>();
            }

            for (int i = 0; i < N; i++)
            {
                var S = ReadLine().ToCharArray();
                for (int j = 0; j < N; j++)
                {
                    if (S[j] == '1')
                    {
                        edge[i].Add(j);
                        edge[j].Add(i);
                    }
                }
            }

            int result = -1;
            for (int i = 0; i < N; i++)
            {
                var que = new Queue<int>();
                que.Enqueue(i);

                var vertexNum = new int[N];
                vertexNum[i] = 1;

                int curSet = 1;

                while (que.Count() > 0)
                {
                    var curVertex = que.Dequeue();
                    foreach (int j in edge[curVertex])
                    {
                        if (vertexNum[j] == 0)
                        {
                            vertexNum[j] = vertexNum[curVertex] + 1;
                            que.Enqueue(j);
                            if (curSet < vertexNum[j])
                            {
                                 curSet = vertexNum[j];
                            }
                        }
                        else if (Abs(vertexNum[j] - vertexNum[curVertex]) == 1)
                            continue;
                        else
                        {
                            curSet = -1;
                            que.Clear();
                            break;
                        }
                    }
                }
                if (curSet > result) result = curSet;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
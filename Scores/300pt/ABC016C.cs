using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC016C
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int M = init[1];

            List<int>[] relation = new List<int>[N + 1];
            for (int j = 1; j <= N; j++)
            {
                relation[j] = new List<int>();
            }

            for (int i = 0; i < M; i++)
            {
                int[] person = ReadLine().Split(' ')
                    .Select(n => int.Parse(n)).ToArray();

                relation[person[0]].Add(person[1]);
                relation[person[1]].Add(person[0]);
            }
            
            for (int j = 1; j <= N; j++)
            {
                Queue<network> net = new Queue<network>();
                net.Enqueue(new network(0, j));

                bool[] friend = new bool[N + 1];
                friend[j] = true;
                int result = 0;
                while (net.Count > 0)
                {
                    network cur = net.Dequeue();
                    int curLevel = cur.GetLevel();
                    int curPerson = cur.GetPerson();

                    if (curLevel == 2)
                    {
                        result++;
                        continue;
                    }

                    foreach (int k in relation[curPerson])
                    {
                        if (friend[k]) continue;
                        if (k == j) continue;
                        net.Enqueue(new network(curLevel + 1, k));
                        friend[k] = true;
                    }
                }
                WriteLine(result.ToString());
            }
            ReadKey();
        }

        internal class network
        {
            private int level;
            private int person;
            
            public network(int level, int person)
            {
                this.level = level;
                this.person = person;
            }

            public int GetLevel()
            {
                return level;
            }

            public int GetPerson()
            {
                return person;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ABC014D
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            List<int>[] LinkVertex = new List<int>[N + 1];
            for (int i = 0; i <= N; i++)
            {
                LinkVertex[i] = new List<int>(); 
            }

            for (int i = 1; i <= N - 1; i++)
            {
                int[] vertex = ReadLine().Split(' ')
                    .Select(n => int.Parse(n)).ToArray();
                int p = vertex[0];
                int q = vertex[1];

                LinkVertex[p].Add(q);
                LinkVertex[q].Add(p);
            }

            int Q = int.Parse(ReadLine());
            int[] departure = new int[Q];
            int[] arrive = new int[Q];
            for (int j = 0; j < Q; j++)
            {
                int[] way = ReadLine().Split(' ')
                    .Select(n => int.Parse(n)).ToArray();
                departure[j] = way[0];
                arrive[j] = way[1];
            }

            for (int j = 0; j < Q; j++)
            {
                int result
                 = dfsSearchWay(departure[j], -1, 0, arrive[j], LinkVertex) + 1;
                WriteLine(result.ToString());
            }
            ReadKey();           
        }

        static int dfsSearchWay(int staying
                                , int prevstay
                                , int distance
                                , int arrive
                                , List<int>[] LinkVertex)
        {
            int result = 0;
            distance++;
            foreach (int l in LinkVertex[staying])
            {
                if (l == arrive) 
                    return distance;
                if (l == prevstay) continue;

                result = dfsSearchWay(l, staying, distance, arrive, LinkVertex);
            }
            return result;
        }
    }
}
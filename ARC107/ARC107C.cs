using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ARC107
{
    class ARC107C
    {
        static readonly long MOD = 998244353;

        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var N = init[0];
            var K = init[1];

            var matrix = new int[N][]
                .Select(v => new int[N]).ToArray();
            for (int i = 0; i < N; i++)
            {
                matrix[i] = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
            }

            var swapAbleColumn = new Union_Find(N);
            for (int x = 0; x < N; x++)
            {
                for (int y = x + 1; y < N; y++)
                {
                    bool swapAble = true;
                    for (int i = 0; i < N; i++)
                    {
                        if (matrix[i][x] + matrix[i][y] > K)
                        {
                            swapAble = false;
                            break;
                        }
                    }
                    // if (swapAble) WriteLine("W: {0} {1}", x, y);
                    if (swapAble) swapAbleColumn.Union(x, y);
                }
            }

            var swapAbleRow = new Union_Find(N);
            for (int x = 0; x < N; x++)
            {
                for (int y = x + 1; y < N; y++)
                {
                    bool swapAble = true;
                    for (int i = 0; i < N; i++)
                    {
                        if (matrix[x][i] + matrix[y][i] > K)
                        {
                            swapAble = false;
                            break;
                        }
                    }
                    // if (swapAble) WriteLine("H: {0} {1}", x, y);
                    if (swapAble) swapAbleRow.Union(x, y);
                }
            } 

            var resultH = new int[N];
            var resultW = new int[N];
            for (int i = 0; i < N; i++)
            {
                resultH[swapAbleRow.Root(i)]++;
                resultW[swapAbleColumn.Root(i)]++;
            }

            long result = 1;
            for (int i = 0; i < N; i++)
            {
                result *= factorial(resultH[i]);
                result %= MOD;
                
                result *= factorial(resultW[i]);
                result %= MOD;
            }
            WriteLine(result.ToString());
            ReadKey();
        }

        static long factorial(long N)
        {
            if (N == 0) return 1;
            long result = 1;
            for (int i = 1; i <= N; i++)
            {
                result *= i;
                result %= MOD;
            }

            return result;
        }

        internal class Union_Find
        {
            internal int[] Parent;
            internal Union_Find(int N)
            {
                // Parent = new int[N + 1];
                // for (int i = 1; i <= N; i++)
                Parent = new int[N];    // for 0-indexed
                for (int i = 0; i < N; i++)
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
}
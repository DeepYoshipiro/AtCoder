using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class diverta2019_2_B
    {
        double[] mostAppearedM;
        int[] mostAppearedMCnt;

        static void Main(string[] args)
        {
            diverta2019_2_B my = new diverta2019_2_B();
            int N = int.Parse(ReadLine());
            double[] x = new double[N];
            double[] y = new double[N];
            double[][] m = new double[N][];
            for (int i = 0; i < N; i++)
            {
                m[i] = new double[N];
                double[] point = ReadLine().Split()
                    .Select(n => double.Parse(n)).ToArray();
                x[i] = point[0];
                y[i] = point[1];
            }

            my.mostAppearedM = new double[N];
            my.mostAppearedMCnt = new int[N];
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (i == j)
                    {
                        m[i][j] = double.MinValue;
                    }
                    else
                    {
                        if (x[i] == x[j])
                        {                    
                            m[i][j] = double.MaxValue;
                        }
                        else
                        {
                            m[i][j] = (y[j] - y[i]) / (x[j] - x[i]);
                        }
                    }
                }
                my.searchMostAppeared(i, m[i]);
            }

            bool[] arrived = new bool[N];

            long result = 0;
            result %= 100000007;
            WriteLine(result.ToString());
            ReadKey();
        }

        internal int searchMostAppeared(int i, double[] m)
        {
            double[] sortedM = m.Where(d => d > double.MinValue)
                .OrderByDescending(d => d).ToArray();
            mostAppearedMCnt[i] = 1;
            double current = sortedM.First();
            int currentContinue = 0;
            for (int k = 0; k < sortedM.Length; k++)
            {
                if (sortedM[k] == current)
                {
                    currentContinue++;
                    if (currentContinue > mostAppearedMCnt[i])
                    {
                        mostAppearedM[i] = current;
                        mostAppearedMCnt[i] = currentContinue;
                    }
                }
                else
                {
                    current = sortedM[k];
                    currentContinue = 1;
                }
            }
            return mostAppearedMCnt[i];
        }
    }
}
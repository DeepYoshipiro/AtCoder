using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC026C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            int[] B = new int[N + 1];
            int[] maxSalary = new int[N + 1];
            int[] minSalary = new int[N + 1];

            B[1] = 0;
            minSalary[1] = int.MaxValue;
            for (int i = 2; i <= N; i++)
            {
                B[i] = int.Parse(ReadLine());
                minSalary[i] = int.MaxValue;
            }

            int[] salary = new int[N + 1];
            for (int i = N; i >= 1; i--)
            {
                if (maxSalary[i] == 0)
                {
                    salary[i] = 1;
                }
                else
                {
                    salary[i] = maxSalary[i] + minSalary[i] + 1;
                }

                if (salary[i] > maxSalary[B[i]])
                {
                    maxSalary[B[i]] = salary[i];
                }

                if (salary[i] < minSalary[B[i]])
                {
                    minSalary[B[i]] = salary[i];
                }
            }

            WriteLine(salary[1].ToString());
            ReadKey();
        }
    }
}
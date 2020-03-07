using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC082C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            int[] a = ReadLine().Split(' ')
                .Select(n => int.Parse(n))
                .OrderBy(n => n)
                .Concat(new int[1]{0}).ToArray();

            int curNum = 0;
            int continiousCnt = 0;
            int result = 0;
            for (int i = 0; i <= N; i++)
            {
                if (a[i] == curNum)
                {
                    continiousCnt++;
                }
                else
                {
                    if (curNum < continiousCnt)
                    {
                        result += continiousCnt - curNum;
                    }
                    else if (curNum > continiousCnt)
                    {
                        result += continiousCnt;
                    }
                    curNum = a[i];
                    continiousCnt = 1;
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
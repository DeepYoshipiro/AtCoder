using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class ABC094D
    {
        static void Main(string[] args)
        {
            int n = int.Parse(ReadLine());
            List<int> a = ReadLine().Split()
                .Select(k => int.Parse(k))
                .ToList();
            
            a.Sort();
            a.Reverse();        

            int i = a[0];
            int result = 0;
            int minCalc = i;
            for (int j = 1; j < n; j++)
            {
                int calc = Max(i - a[j], a[j]);
                if (calc <= minCalc) 
                {
                    result = a[j];
                    minCalc = calc;
                }
                else{
                    break;
                }
            }

            WriteLine(i.ToString() + " " + result.ToString());
            ReadKey();
        }
    }
}
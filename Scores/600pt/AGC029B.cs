using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _600pt
{
    class AGC029B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            List<long> a = ReadLine().Split()
                        .Select(n => long.Parse(n))
                        .OrderBy(n => n).ToList(); 

            int result = 0;
            while (a.Count > 1)
            {
                bool match = false;
                long find = (long)Pow(2, (long)Log(a.Last() * 2, 2)) - a.Last();
                int lower = 0;
                int upper = a.Count - 2;
                while (upper >= lower)
                {
                    int mid = (lower + upper) / 2;
                    if (a[mid] == find)
                    {
                        result++;
                        match = true;
                        lower = mid;
                        upper = mid;
                        a.RemoveAt(a.Count - 1);
                        a.RemoveAt(mid);
                        break;
                    }
                    else if (a[mid] < find)
                    {
                        lower = ++mid;
                    }
                    else
                    {
                        upper = --mid;
                    }
                }
                if (!match)
                {
                    a.RemoveAt(a.Count - 1);
                }
            }
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}

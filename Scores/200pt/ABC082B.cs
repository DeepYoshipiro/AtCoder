using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _200pt
{
    class ABC082B
    {
        static void Main(string[] args)
        {
            char[] s = ReadLine().OrderBy(u => u).ToArray();
            char[] t = ReadLine().OrderBy(u => u).ToArray();

            //calculate & output
            bool result = (s.Length < t.Length ? true: false);
            for (int i = 0; i < Min(s.Length, t.Length); i++)
            {
                if (s[i].Equals(t[i])) continue; 
                if (s[i] < t[i]) 
                {
                    result = true;
                    break;
                }
                else{
                    result = false;
                    break;
                }
            }

            WriteLine(result ? "Yes " : "No");
            ReadKey();
        }
    }
}

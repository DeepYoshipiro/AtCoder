using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _200pt
{
    class ABC043B
    {
        static void Main(string[] args)
        {
            //input
            char[] s = ReadLine().ToCharArray();

            List<char> result = new List<char>();
            //calculate
            for (int i = 0; i < s.Length; i++) {
                if (s[i].Equals('B'))
                {
                    if (result.Count > 0) result.RemoveAt(result.Count - 1);
                }
                else {
                    result.Add(s[i]);
                }

            }

            WriteLine(result.ToArray());
            ReadKey();
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class DWC2018PrelimsB
    {
        static void Main(string[] args)
        {
            //input
            string s = ReadLine();

            //calculate
            int result = 0;
            int len = s.Length;
            while (s.Length > 0) {
                s = s.Replace("25", "");
                if (len == s.Length) {
                    result = -1;
                    break;
                }
                result++;
                len = s.Length;
            }

            //output;
            WriteLine(result.ToString());
            ReadKey();
        }

    }
}

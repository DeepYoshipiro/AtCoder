using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _100pt
{
    class ABC059A
    {
        static void Main(string[] args)
        {
            string[] s = Console.ReadLine()
                        .Split(' ').ToArray();
 
            //calculate & output
            string S = ""; 
            S = s[0].ToUpper().Substring(0, 1);
            S += s[1].ToUpper().Substring(0, 1);
            S += s[2].ToUpper().Substring(0, 1);

            WriteLine(S);
            ReadKey();
        }
    }
}

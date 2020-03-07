using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _100pt
{
    class ABC079A
    {
        static void Main(string[] args)
        {
            char[] N = ReadLine().ToCharArray();

            bool result = false;
            if ((N[0].Equals(N[1]) && N[0].Equals(N[2]))
                || (N[1].Equals(N[2]) && N[1].Equals(N[3])))
            {
                result = true;
            }

            WriteLine(result ? "Yes" : "No");
            ReadKey();
        }
    }
}
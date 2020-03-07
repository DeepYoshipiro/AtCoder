using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _100pt
{
    class ABC088A
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            int A = int.Parse(ReadLine());

            bool result = false;
            if (A >= 500 || N % 500 <= A)
            {
                result = true;
            }

            WriteLine(result ? "Yes" : "No");
            ReadKey();
        }
    }
}
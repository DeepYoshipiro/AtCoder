using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC171
{
    class ABC171C
    {
        static void Main(string[] args)
        {
            var N = long.Parse(ReadLine());

            string result = "";
            while (N > 0)
            {
                N--;
                result = (char)(N % 26 + 'a') + result;
                N /= 26;
            };        

            WriteLine(result);
            ReadKey();
        }
    }
}

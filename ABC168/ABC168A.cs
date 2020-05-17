using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC168
{
    class ABC168A
    {
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());
            N %= 10;
            var result = "";
            switch (N)
            {
                case 3:
                    result = "bon";
                    break;
                case 0:
                case 1:
                case 6:
                case 8:
                    result = "pon";
                    break;
                default:
                    result = "hon"; 
                    break;
            }

            WriteLine(result);
            ReadKey();
        }
    }
}

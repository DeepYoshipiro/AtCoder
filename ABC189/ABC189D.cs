using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC189
{
    class ABC189D
    {
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());

            long curTrue = 1;
            long universe = 2;
            for (int i = 1; i <= N; i++)
            {
                var S = ReadLine();
                universe *= 2;
                switch (S)
                {
                    case "AND":
                        break;
                    case "OR":
                        curTrue *= 2;
                        curTrue += (universe - curTrue) / 2;
                        break; 
                }
            }

            WriteLine(curTrue);
            ReadKey();
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC146
{
    class ABC146A
    {
        static void Main(string[] args)
        {
            //int N = int.Parse(ReadLine());
            string S = ReadLine();

            int result = 0;
            switch (S)
            {
                case "SUN":
                    result = 7;
                    break;
                case "MON":
                    result = 6;
                    break;
                case "TUE":
                    result = 5;
                    break;
                case "WED":
                    result = 4;
                    break;
                case "THU":
                    result = 3;
                    break;
                case "FRI":
                    result = 2;
                    break;
                case "SAT":
                    result = 1;
                    break;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}

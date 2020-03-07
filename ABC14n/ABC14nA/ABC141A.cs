using System;
using System.Linq;
using System.Collections.Generic;
using static System.Console;
using static System.Math;

namespace ABC141
{
    class ABC141A
    {
        static void Main(string[] args)
        {
            string S = ReadLine();

            switch (S) {
                case "Sunny":
                    WriteLine("Cloudy");
                    break;
                case "Cloudy":
                    WriteLine("Rainy");
                    break;
                case "Rainy":
                    WriteLine("Sunny");
                    break;
            }

            ReadKey();
        }
    }
}

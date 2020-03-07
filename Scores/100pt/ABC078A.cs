using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _100pt
{
    class ABC078A
    {
        static void Main(string[] args)
        {
            char[] init = ReadLine().ToCharArray();
            char X = init[0];
            char Y = init[2];

            int diff = Sign(X - Y);
            switch (diff)
            {
                case -1:
                    WriteLine("<");
                    break;
                case 0:
                    WriteLine("=");
                    break;
                case 1:
                    WriteLine(">");
                    break;
            }

            ReadKey();
        }
    }
}            
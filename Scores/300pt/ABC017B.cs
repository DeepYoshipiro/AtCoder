using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC017B
    {
        static void Main(string[] args)
        {
            char[] X = ReadLine().ToCharArray();

            bool result = true;
            for (int i = X.Length - 1; i >= 0; i--)
            {
                switch (X[i])
                {
                    case 'h':
                        if (i > 0 && X[i - 1] == 'c')
                        {
                            i--;
                            break;
                        }
                        else
                        {
                            result = false;
                            break;
                        }
                    case 'o':
                    case 'k':
                    case 'u':
                        break;
                    default:
                        result = false;
                        break;
                }
                if (!result) break;
            }

            WriteLine(result ? "YES" : "NO");
            ReadKey();
        }
    }
}
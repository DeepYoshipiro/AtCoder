using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _200pt
{
    class ABC084B
    {
        static void Main(string[] args)
        {
            int[] init = Console.ReadLine().Split(' ')
                        .Select(n => int.Parse(n)).ToArray();
            int A = init[0];
            int B = init[1];

            char[] S = ReadLine().ToCharArray();

            bool result = true;
            for (int i = 0; i <= A + B; i++){
                if (i == A)
                {
                    if (!S[i].Equals('-'))
                    {
                        result = false;
                        break;
                    }
                }
                else if (S[i] < '0' || S[i] > '9')
                {
                    result = false;
                    break;
                }
            }

            WriteLine(result ? "Yes" : "No");
            ReadKey();
        }
    }
}
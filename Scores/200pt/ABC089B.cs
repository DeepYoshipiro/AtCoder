using System;
using System.Linq;
using static System.Console;

namespace _200pt
{
    class ABC089B
    {
        static void Main(string[] args)
        {
            //input
            int N = int.Parse(ReadLine());
            string[] S = ReadLine().Split(' ').ToArray();

            //calculate & output
            string result = "Three";
            for (int i = 0; i < N; i++) {
                if (S[i].Equals("Y"))
                {
                    result = "Four";
                    break;
                }
            }

            WriteLine(result);
            ReadKey();
        }
    }
}

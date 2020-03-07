using System;
using static System.Console;


namespace ABC139
{
    class ABC139A
    {
        static void Main(string[] args)
        {
            //input
            char[] S = ReadLine().ToCharArray();
            char[] T = ReadLine().ToCharArray();

            //calculation
            int result = 0;
            if (S[0].Equals(T[0])) result++;
            if (S[1].Equals(T[1])) result++;
            if (S[2].Equals(T[2])) result++;

            //output
            WriteLine(result.ToString());
        }
    }
}

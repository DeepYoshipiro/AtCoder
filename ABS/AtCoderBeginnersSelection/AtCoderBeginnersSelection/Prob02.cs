using System;
using static System.Console;

namespace AtCoderBeginnersSelection
{
    class Prob02
    {
        static void Main(string[] args)
        {
            // input
            char[] s = ReadLine().ToCharArray();

            // calculate
            int result = 0;
            if (s[0].Equals('1')) result++;
            if (s[1].Equals('1')) result++;
            if (s[2].Equals('1')) result++;

            // output
            WriteLine(result);
        }
    }
}

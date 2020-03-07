using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class Tenka1_2019BeginnerC
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            char[] S = ReadLine().ToCharArray();

            int result = 0;
            int blackPool = 0;
            for (int i = 0; i < N; i++)
            {
                switch (S[i])
                {
                    case '#':
                        blackPool++;
                        break;
                    case '.':
                        if (blackPool > 0)
                        {
                            blackPool--;
                            result++;
                        }
                        break;
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}

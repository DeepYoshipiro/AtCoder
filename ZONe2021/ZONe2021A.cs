using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ZONe2021
{
    class ZONe2021A
    {
        static void Main(string[] args)
        {
            var S = ReadLine().ToCharArray();

            int result = 0;
            for (int i = 0; i < 12 - 3; i++)
            {
                if (S[i] == 'Z')
                {
                    result += 
                        S[i + 1] == 'O' && S[i + 2] == 'N'
                         && S[i + 3] =='e' ? 1 : 0;
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}

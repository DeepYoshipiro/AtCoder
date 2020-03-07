using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _400pt
{
    class SummiTrust2019D
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            string S = ReadLine();

            int result = 0;
            for (int pin = 0; pin <= 999; pin++)
            {
                char[] p = pin.ToString().PadLeft(3, '0').ToCharArray();

                int find1st = S.IndexOf(p[0]);

                int find2nd
                 = (find1st >= 0 ?
                     S.Substring(find1st + 1).IndexOf(p[1]) : -1);

                int find3rd 
                 = (find2nd >= 0 ?
                     S.Substring(find1st + find2nd + 2).IndexOf(p[2]) : -1);

                result += (find1st >= 0 && find2nd >= 0 & find3rd >= 0)
                        ? 1 : 0;
            }
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
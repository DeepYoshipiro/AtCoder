using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _200pt
{
    class ABC090B
    {
        static void Main(string[] args)
        {
            int[] init = Console.ReadLine().Split(' ')
                        .Select(n => int.Parse(n)).ToArray();
            int A = init[0];   //A以上
            int B = init[1];   //B以下

            int result = 0;
            for (int org = A; org <= B; org++)
            {
                int tmp = org;
                int conv = 0;
                for (int j = 0; j < 5; j++)
                {
                    int digit = tmp / (int)Pow(10, 4 - j);
                    tmp -= digit * (int)Pow(10, 4 - j);
                    digit *= (int)Pow(10, j);
                    conv += digit;
                }
                if (org == conv) result++;
            }
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}

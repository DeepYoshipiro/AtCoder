using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ACLBC
{
    class ACLBC_B
    {
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => long.Parse(n)).ToArray();
            var A1 = init[0];
            var A2 = init[1];
            var B1 = init[2];
            var B2 = init[3];

            bool result = false;
            if (A1 <= B1 && A2 >= B1) result = true;
            else if (B1 <= A1 && B2 >= A1) result = true;

            WriteLine(result ? "Yes" : "No");
            ReadKey();
        }
    }
}

using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC166
{
    class ABC166D
    {
        static void Main(string[] args)
        {
            long X = long.Parse(ReadLine());

            List<int> origin = new List<int>();
            List<long> pow5 = new List<long>();
            for (int i = -73; i <= 73; i++)
            {
                origin.Add(i);
                pow5.Add(i * i * i * i * i);
            }

            for (int a = 146; a >= 0; a--)
            {
                for (int b = a; b >= 0; b--)
                {
                    if (pow5[a] - pow5[b] == X)
                    {
                        WriteLine("{0} {1}", origin[a], origin[b]);
                        ReadKey();
                        return;                        
                    }
                }
            }

            WriteLine("-1");
            ReadKey();
        }
    }
}

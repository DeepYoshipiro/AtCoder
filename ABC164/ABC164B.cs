using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace ABC164
{
    class ABC164B
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            int THp = init[0];
            int TAttack = init[1];
            int HHp = init[2];
            int HAttack = init[3];

            bool TWin = false;
            while (THp > 0 && HHp > 0)
            {
                HHp -= TAttack;
                if (HHp <= 0)
                {
                    TWin = true;
                    break;
                }

                THp -= HAttack;
            }

            WriteLine(TWin ? "Yes" : "No");
            ReadKey();
        }
    }
}

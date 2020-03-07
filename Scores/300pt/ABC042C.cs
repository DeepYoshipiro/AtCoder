using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC042C
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                    .Select(n => int.Parse(n)).ToArray();
            int price = init[0];
            
            int[] hate = ReadLine().Split(' ')
                    .Select(n => int.Parse(n)).ToArray();

            int y = price;
            bool feelIroha;
            do
            {
                string pay = y.ToString();
                feelIroha = true;
                for (int i = 0; i < hate.Count(); i++)
                {
                    if (pay.Contains(hate[i].ToString()))
                    {
                        feelIroha = false;
                        y++;
                        break;
                    };
                }
            } while (!feelIroha);

            WriteLine(y.ToString());
            ReadKey();
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC135C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            int[] monster = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int[] soldier = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();

            int result = 0;
            for (int i = 0; i < N; i++)
            {
                int able = soldier[i];
                
                int attack = Min(able, monster[i]);
                monster[i] -= attack;
                able -= attack;
                result += attack;
                
                attack = Min(able, monster[i + 1]);
                monster[i + 1] -= attack;
                result += attack;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
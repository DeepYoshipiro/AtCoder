using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC153
{
    public class Monster
    {
        public int Point { get; set; }
        public long HP { get; set; }
    }

    public class ABC153F
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(m => int.Parse(m)).ToArray();
            int N = init[0];
            int D = init[1];
            int A = init[2];

            List<Monster> monster = new List<Monster>();
            for (int n = 0; n < N; n++)
            {
                int[] info = ReadLine().Split(' ')
                    .Select(m => int.Parse(m)).ToArray();
                int X = info[0];
                int H = info[1];

                monster.Add(
                    new Monster(){ Point = X, HP = H }
                );
            }

            monster.Sort((a, b) => a.Point - b.Point);
            Queue<Monster> damaged = new Queue<Monster>();
            long damagedSum = 0;
            long attackCnt = 0;
            foreach (Monster mon in monster)
            {
                int left = mon.Point;
                int right = mon.Point + 2 * D;

                while (damaged.Count > 0 && damaged.Peek().Point <= left)
                {
                    damagedSum -= damaged.Dequeue().HP;
                }

                long curHP = mon.HP - damagedSum;
                if (curHP > 0)
                {
                    long bomb = (curHP + A - 1) / A;
                    attackCnt += bomb;
                    damagedSum += bomb * A;
                    damaged.Enqueue(
                        new Monster(){ Point = right + 1, HP = bomb * A}
                        );                  
                }
            }
            WriteLine(attackCnt.ToString());
            ReadKey();
        }
    }
}
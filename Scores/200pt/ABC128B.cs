using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _200pt
{
    class ABC128B
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());

            List<Restraunt> restrauntInfo = new List<Restraunt>();
            for (int i = 0; i < N; i++)
            {
                string[] info = ReadLine().Split();
                restrauntInfo.Append(new Restraunt(i + 1, info[0], int.Parse(info[1])));
            }
            var restrauntAfterSort = restrauntInfo.OrderBy(r => r.city).OrderByDescending(r => r.score);
            Dictionary<int, Restraunt> restrauntDictonary = restrauntAfterSort.ToDictionary(r => r.id);

            foreach (KeyValuePair<int, Restraunt> pair in restrauntDictonary) {
                WriteLine(pair.Key);
            }
            ReadKey();
        }
    }

    internal class Restraunt
    {
        public int id;
        public string city;
        public int score;

        public Restraunt(int i, string c, int s)
        {
            id = i;
            city = c;
            score = s;
        }
    }
}

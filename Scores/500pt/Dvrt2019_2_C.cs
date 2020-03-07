using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _500pt
{
    class Dvrt2019_2_C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            long[] A = ReadLine().Split()
                    .Select(n => long.Parse(n)).ToArray();

            List<long> plus = A.Where(n => n >= 0)
                    .OrderByDescending(n => n).ToList();
            List<long> minus = A.Where(n => n < 0)
                    .OrderBy(n => n).ToList();
            
            List<Substraction> result = new List<Substraction>();

            while (Abs(plus.Count() - minus.Count()) > 1 && plus.Count() + minus.Count > 2)
            {
                if (plus.Count() > minus.Count())
                {
                    long newMinus = plus.Last() - plus.First();
                    result.Add(new Substraction(plus.Last(), plus.First()));
                    plus.RemoveAt(plus.Count() - 1);
                    plus.RemoveAt(0);
                    if (newMinus < 0)
                    {
                        minus.Add(newMinus);
                    }
                    else
                    {
                        plus.Add(newMinus);
                    }
                    if (plus.Count() == 2)
                    {
                        plus.Sort();
                        plus.Reverse();
                    }
                }
                else
                {
                    long newPlus = minus.Last() - minus.First();
                    result.Add(new Substraction(minus.Last(), minus.First()));
                    plus.Add(newPlus);
                    minus.RemoveAt(minus.Count() - 1);
                    minus.RemoveAt(0);
                    if (minus.Count() == 2)
                    {
                        minus.Sort();
                    }
                }

            }

            List<long> process = new List<long>();
            int pairDiff = plus.Count() - minus.Count();
            int sign = 1;
            switch (pairDiff)
            {
                case 1:
                    process.Add(plus.First());
                    plus.RemoveAt(0);
                    break;
                case -1:
                    process.Add(minus.First());
                    minus.RemoveAt(0);
                    sign = -1;
                    break;
                default:
                    break;
            }

            for (int i = 0; i < plus.Count(); i++)
            {
                sign *= -1;
                if (sign > 0)
                {
                    result.Add(new Substraction(plus[i], minus[i]));
                    process.Add(plus[i] - minus[i]);
                }
                else
                {
                    result.Add(new Substraction(minus[i], plus[i]));
                    process.Add(minus[i] - plus[i]);
                }
            }

            while (process.Count > 2)
            {
                result.Add(new Substraction(process[0], process[1]));
                process[1] -= process[0];
                process.RemoveAt(0);
            }

            long sum;
            if (process.Count >= 2)
            {
                sum = Abs(process[0] - process[1]);
                if (process[0] - process[1] >= 0)
                {
                    result.Add(new Substraction(process[0], process[1]));
                }
                else
                {
                    result.Add(new Substraction(process[1], process[0]));
                }
            }
            else
            {
                sum = process[0];
            }

            WriteLine(sum.ToString());
            foreach(Substraction cur in result)
            {            
                WriteLine("{0} {1}", cur.x, cur.y);
            }
            ReadKey();
        }
    }

    internal class Substraction
    {
        public long x {get;}
        public long y {get;}

        public Substraction(long _x, long _y)
        {
            x = _x;
            y = _y;
        }
    } 
}
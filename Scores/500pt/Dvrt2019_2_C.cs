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
                    .OrderBy(n => n).ToList();
            List<long> minus = A.Where(n => n < 0)
                    .OrderByDescending(n => n).ToList();

            int plusCursor = 0;
            int minusCursor = 0;

            List<Substraction> process = new List<Substraction>();
            long result = 0;
            while (
                (plus.Count() - plusCursor)
                 + (minus.Count() - minusCursor) > 1)
            {
                int plusFlag = Sign((plus.Count() - plusCursor) - 1);
                int minusFlag = Sign((minus.Count() - minusCursor) - 1);
                switch (plusFlag * 3 + minusFlag)
                {
                    case 4: // plus >= 2, minus >= 2
                    case 3: // plus >= 2, minus = 1
                        result = minus[minusCursor] - plus[plusCursor];
                        process.Add(new Substraction(minus[minusCursor], plus[plusCursor]));
                        minusCursor++;
                        plusCursor++;
                        minus.Add(result);
                        break;
                    case 1: // plus = 1, minus >= 2
                    case 0: // plus = 1, minus = 1
                        result = plus[plusCursor] - minus[minusCursor];
                        process.Add(new Substraction(plus[plusCursor], minus[minusCursor]));
                        plusCursor++;
                        minusCursor++;
                        plus.Add(result);
                        break;
                    case 2: // plus >= 2, minus = 0;
                        if (plus.Count() - plusCursor == 2)
                        {
                            result = plus[plusCursor + 1] - plus[plusCursor];
                            process.Add(new Substraction(plus[plusCursor + 1], plus[plusCursor]));
                            plusCursor += 2;
                            plus.Add(result);
                        }
                        else
                        {
                            result = plus[plusCursor] - plus[plusCursor + 1];
                            process.Add(new Substraction(plus[plusCursor], plus[plusCursor + 1]));
                            plusCursor += 2;
                            minus.Add(result);
                        }
                        break;
                    default: // plus = 0, minus >= 2
                        result = minus[minusCursor] - minus[minusCursor + 1];
                        process.Add(new Substraction(minus[minusCursor], minus[1]));
                        minusCursor += 2;
                        plus.Add(result);
                        break;
                }
            }

            WriteLine(result.ToString());
            foreach(Substraction cur in process)
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

    class BaseAlgorithm
    {
        internal void Swap(int A, int B)
        {
            int tmp = A;
            A = B;
            B = tmp;
        }
    }

}
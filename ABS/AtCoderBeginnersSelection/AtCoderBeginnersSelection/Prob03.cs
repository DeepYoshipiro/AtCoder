using System;
using System.Linq;
using static System.Console;

namespace AtCoderBeginnersSelection
{
    class Prob03
    {
        static void Main(string[] args)
        {
            // input
            int N = int.Parse(ReadLine());
            int[] A = ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();

            // calculate
            int result = 0;
            bool divideAble = true;
            do {
                for (int i = 0; i < N; i++)
                {
                    if (A[i] % 2 == 0) {
                        A[i] /= 2;
                    }
                    else {
                        divideAble = false;
                        break;
                    }
                }
                result++;
            }while(divideAble);

            // output
            result--;   // 1回余計に加算されているはずなので
            WriteLine(result);
        }
    }
}

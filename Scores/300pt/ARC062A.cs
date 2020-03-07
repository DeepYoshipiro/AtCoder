using System;
using static System.Console;
using System.Linq;

namespace _300pt
{
    class ARC062A
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());

            int[] init = ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();

            long T = init[0];
            long A = init[1];

            for (int i = 2; i <= N; i++)
            {
                int[] info = ReadLine().Split(' ').Select(n => int.Parse(n)).ToArray();
                int times = info[0] + info[1];

                long lack = (times - (T + A) % times) % times;
                if (lack == 0 && (T * info[1] != A * info[0])) lack = times;
                bool satisfy = false;
                while (!satisfy) {
                    for (int j = 0; j <= lack; j++)
                    {
                        if ((T + j) * info[1] == (A + lack - j) * info[0])
                        {
                            T += j;
                            A += lack - j;
                            satisfy = true;
                            break;
                        }
                    }
                    lack += times;
                }
            }

            WriteLine((T + A).ToString());
            ReadKey();
        }
    }
}

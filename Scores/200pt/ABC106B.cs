using System;

namespace _200pt
{
    class ABC106B
    {
        static void Main(string[] args)
        {
            //input
            int N = int.Parse(Console.ReadLine());

            //calculate
            int result = 0;

            for (int i = 1; i <= N; i += 2)
            {
                int divisorCnt = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        divisorCnt++;
                    }

                }
                if (divisorCnt == 8) result++;
            }

            Console.WriteLine(result.ToString());
            Console.ReadKey();
        }
    }
}

using System;
using System.Linq;

namespace _200pt
{
    class ABC052B
    {
        static void Main(string[] args)
        {
            //input
            int N = int.Parse(Console.ReadLine());
            char[] S = Console.ReadLine().ToCharArray();

            //calculate
            int result = 0;
            int x = 0;
            for (int i = 0; i < N; i++) {
                if (S[i].Equals('I'))
                {
                    x++;
                    if (x > result) result = x;
                }
                else if (S[i].Equals('D'))
                {
                    x--;
                }
            }

            Console.WriteLine(result.ToString());
            Console.ReadKey();
        }
    }
}

using System;

namespace _200pt
{
    class ABC066B
    {
        static void Main(string[] args)
        {
            //input
            string S = Console.ReadLine();

            //calculate
            int result = 0;

            for (int i = S.Length / 2 - 1; i >= 1; i--) {
                if (S.Substring(0, i).Equals(S.Substring(i, i)))
                {
                    result = 2 * i;
                    break;
                }
            }

            Console.WriteLine(result.ToString());
            Console.ReadKey();
        }
    }
}

using System;

namespace _200pt
{
    class ABC077B
    {
        static void Main(string[] args)
        {
            //input
            int N = int.Parse(Console.ReadLine());

            //calculate
            int result = (int)Math.Floor(Math.Sqrt(N));
            result *= result;

            Console.WriteLine(result.ToString());
            Console.ReadKey();
        }
    }
}

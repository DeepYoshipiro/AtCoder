using System;

namespace abc138
{
    class abc138a
    {
        static void Main(string[] args)
        {
            // input
            int a = int.Parse(Console.ReadLine());
            string s = Console.ReadLine();

            // output
            if (a >= 3200)
            {
                Console.WriteLine(s);
            }
            else {
                Console.WriteLine("red");
            }            
        }
    }
}

using System;
using System.Linq;
using static System.Console;

namespace _200pt
{
 
    class ABC119B
    {
        static void Main(string[] args)
        {
            //input and calculate
            int N = int.Parse(ReadLine());
            const decimal bitCoinRate = 380000;

            decimal result = 0;
            for (int i=0; i < N; i++)
            {
                string[] input = ReadLine().Split(' ').ToArray();
                decimal x = decimal.Parse(input[0]);
                string u = input[1];   //通貨単位

                if (u.Equals("JPY"))
                {
                    result += x;
                }
                else {
                    result += x * bitCoinRate;
                }
            }

            //output;
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}

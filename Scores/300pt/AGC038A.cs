using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;


namespace AGC038
{
    class AGC038A
    {
        static void Main(string[] args)
        {
            //input
            long[] input = ReadLine().Split(' ').Select(n => long.Parse(n)).ToArray();
            long A = input[0];
            long B = input[1];
            long K = input[3];

            //calculate & output
            long signK = (K % 2 == 0 ? 1 : -1);
            long result = signK * (A - B);  //連立の漸化式変形したら、こうなったやつ

            if (Abs(result) > Pow(10, 18)) 
            {
                //実は、このケースはないのでは？
                WriteLine("Unfair");
            }
            else
            {
                WriteLine(result.ToString());
            }

            ReadKey();
        }
    }
}

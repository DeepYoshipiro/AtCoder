using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC187
{
    class ABC187D
    {
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());

            long winT = 0;
            var diffSpeech = new long[N]; 
            for (int i = 0; i < N; i++)
            {
                var init = ReadLine().Split()
                    .Select(n => long.Parse(n)).ToArray();
                var A = init[0];
                var B = init[1];

                diffSpeech[i] = 2 * A + B;
                winT -= A;
            }

            Array.Sort(diffSpeech);
            Array.Reverse(diffSpeech);

            int result = 0;
            for (int i = 0; i < N; i++)
            {
                winT += diffSpeech[i];

                if (winT > 0)
                {
                    result = i + 1;
                    break;
                }
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}

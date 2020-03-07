using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace _300pt
{
    class ABC111C
    {
        static void Main(string[] args)
        {
            const int MAX_V = 100000;

            int n = int.Parse(ReadLine());
            int[] v = (new int[1]{0}).Concat(
                    ReadLine().Split(' ').Select(m => int.Parse(m))
                    ).ToArray();

            int[] ONT = new int[n / 2 + 1];  // Odd Numbered Term 
            int[] ENT = new int[n / 2 + 1];  // Even Numbered Term

            int[] ONT_appearedNum = new int[MAX_V + 1];
            int[] ENT_appearedNum = new int[MAX_V + 1];

            for (int i = 1; i <= n / 2; i++)
            {
                ONT[i] = v[i * 2 - 1];
                ONT_appearedNum[ONT[i]]++;

                ENT[i] = v[i * 2];
                ENT_appearedNum[ENT[i]]++;
            }

            // 奇数項優先
            int resultOdd = 0;
            int minOddChangeElement = n / 2;
            int acceptedOddTermNum = 0;
            for (int i = 1; i <= n / 2; i++)
            {
                int oddChangeElement = n / 2 - ONT_appearedNum[ONT[i]];
                if (minOddChangeElement > oddChangeElement)
                {
                    minOddChangeElement = oddChangeElement;
                    acceptedOddTermNum = ONT[i];
                } 
            }
            resultOdd += minOddChangeElement;

            int minEvenChangeElement = n / 2;
            for (int j = 1; j <= n / 2; j++)
            {
                int evenChangeElement = n / 2;
                if (acceptedOddTermNum != ENT[j])
                    evenChangeElement -= ENT_appearedNum[ENT[j]];

                if (evenChangeElement < minEvenChangeElement)
                    minEvenChangeElement = evenChangeElement;
            }
            resultOdd += minEvenChangeElement;

            // 偶数項優先
            int resultEven = 0;
            minEvenChangeElement = n / 2;
            int acceptedEvenTermNum = 0;
            
            for (int j = 1; j <= n / 2; j++)
            {
                int evenChangeElement = n / 2 - ENT_appearedNum[ONT[j]];
                if (evenChangeElement < minEvenChangeElement)
                {
                    minEvenChangeElement = evenChangeElement;
                    acceptedEvenTermNum = ENT[j];
                }
            }
            resultEven += minEvenChangeElement;

            minOddChangeElement = n / 2;
            for (int i = 1; i <= n / 2; i++)
            {
                int oddChangeElement = n / 2;
                if (acceptedOddTermNum != ONT[i])
                    oddChangeElement -= ONT_appearedNum[ONT[i]];

                if (minOddChangeElement > oddChangeElement)
                {
                    minOddChangeElement = oddChangeElement;
                } 
            }
            resultEven += minOddChangeElement;
            
            WriteLine(Min(resultOdd, resultEven).ToString());
            ReadKey();
        }
    }
}
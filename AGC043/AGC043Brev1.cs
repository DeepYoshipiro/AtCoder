using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace AGC043
{
    class AGC043Brev1
    {
        const int MOD = 2;

        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            char[] a = ReadLine().ToCharArray();

            bool TrivialBase1 = true;
            bool TrivialBase3 = true;
            for (int i = 1; i < N - 1; i++)
            {
                if (a[i] != '1') TrivialBase1 = false;
                if (a[i] != '3') TrivialBase3 = false;
            }
            if (TrivialBase1 || TrivialBase3)
            {
                if ((a[0] == '1' && a[N - 1] == '3')
                    || (a[0] == '3' && a[N - 1] == '1'))
                {
                    WriteLine('2');
                    ReadKey();
                    return;
                }
            }

            int[] Include2 = new int[N];
            int Pow2 = 2;
            while (Pow2 <= N)
            {
                for (int q = Pow2; q < N; q += Pow2)
                {
                    Include2[q]++;
                }
                Pow2 *= 2;
            }

            int[] CombMod2 = new int[N];
            CombMod2[0] = 1;

            int[] CombInclude2 = new int[N]; 
            CombInclude2[0] = 0;
            CombInclude2[1] = Include2[N - 1];
            CombMod2[1] = 1 - Sign(CombInclude2[1]);

            for (int i = 2; i < N; i++)
            {
                CombInclude2[i] = CombInclude2[i - 1];
                CombInclude2[i] += Include2[N - i] - Include2[i];
                CombMod2[i] = 1 - Sign(CombInclude2[i]); 
            }

            int Sum = 0;
            for (int i = 0; i < N; i++)
            {
                int mod2 = (a[i] - '0') % MOD;
                mod2 *= CombMod2[i];
                Sum += (int)(mod2);
            }
            Sum %= MOD;
            
            WriteLine(Sum.ToString());
            ReadKey();
        }        
    }
}
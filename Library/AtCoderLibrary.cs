using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace Library
{
    class LibraryTest
    {
        static void Main(string[] args)
        {
            int A = 38;
            int B = 16;
            BaseAlgorithm ba = new BaseAlgorithm();
            ba.Swap(ref A, ref B);            
            // WriteLine("{0} {1}", A, B);
            NumberTheory nt = new NumberTheory();
            int result = nt.GCD(A, B);
            WriteLine(result.ToString());
            ReadKey();
        }
    }

    class BaseAlgorithm
    {
        internal void Swap(ref int A, ref int B)
        {
            int tmp = A;
            A = B;
            B = tmp;
        }
    }

    class NumberTheory
    {
        internal int GCD(int A, int B)
        {
            if (A < B)
            {
                BaseAlgorithm ba = new BaseAlgorithm();
                ba.Swap(ref A, ref B);
            }

            int R = A;

            while (R > 0)
            {
                R = A % B;
                A = B;
                B = R;
            }
            return A;
        }
    }
}

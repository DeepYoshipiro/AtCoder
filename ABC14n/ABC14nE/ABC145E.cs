using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC145
{
    class ABC145E
    {
        class Menu
        {
            internal int A{get;}
            internal int B{get;}

            internal Menu(int _A, int _B)
            {
                A = _A;
                B = _B;
            }
        }
        static void Main(string[] args)
        {
            var init = ReadLine().Split()
                .Select(n => int.Parse(n)).ToArray();
            var N = init[0];
            var T = init[1];

            var dpSatisfy = new int[N + 1][]
                .Select(v => new int[T]).ToArray();

            var E = new List<Menu>();
            E.Add(new Menu(0, 0));
            for (int i = 1; i <= N; i++)
            {
                var info = ReadLine().Split()
                    .Select(n => int.Parse(n)).ToArray();
                var A = info[0];
                var B = info[1];
                E.Add(new Menu(A, B));
            }

            var result = 0;

            for (int mode = 0; mode <= 1; mode++)
            {
                switch (mode)
                {
                    case 0:
                        E = E.OrderBy(time => time.A)
                            .ThenBy(satisfy => satisfy.B).ToList();
                        break;
                    case 1:
                        E = E.OrderBy(satisfy => satisfy.B)
                            .ThenBy(time => time.A).ToList();
                        break;
                }

                for (int i = 1; i <= N - 1; i++)
                {                
                    dpSatisfy[i] = (int[])dpSatisfy[i - 1].Clone();
                    // WriteLine("{0} : Satisfy {1}", i, E[i].B);
                    for (int j = 0; j < T; j++)
                    {
                        if (j + E[i].A < T)
                        {
                            dpSatisfy[i][j + E[i].A]
                                = Max(dpSatisfy[i - 1][j + E[i].A]
                                    , dpSatisfy[i - 1][j] + E[i].B
                                    );
                        }
                        // Write("{0} ", dpSatisfy[i][j]);
                    }
                    // WriteLine();
                }
                // WriteLine(dpSatisfy[N - 1][T - 1] + E[N].B);
                result = Max(dpSatisfy[N - 1][T - 1] + E[N].B
                        , result); 
            }
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}

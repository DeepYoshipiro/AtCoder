using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC187
{
    class ABC187C
    {
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());

            var dic = new Dictionary<string, int>();
            for (int i = 0; i < N; i++)
            {
                var S = ReadLine();

                var excla = 0;
                if (S.Substring(0, 1) == "!")
                {
                    excla++;
                    S = S.Substring(1);
                }

                if (dic.ContainsKey(S))
                {
                    if (dic[S] != excla)
                    {
                        WriteLine(S);
                        ReadKey();
                        return;
                    }
                }
                else
                {
                    dic.Add(S, excla);
                }
            }

            WriteLine("satisfiable");
            ReadKey();
        }
    }
}

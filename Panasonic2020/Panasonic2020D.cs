using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace Panasonic2020
{
    class Panasonic2020D
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            List<Stnd>[] Normal = new List<Stnd>[N + 1];
            for (int i = 0; i <= N; i++)
            {
                Normal[i] = new List<Stnd>();
            }
//"a", 1;
//"a", 1 → "aa", 1, "ab", 2;

            List<Stnd> stnd = new List<Stnd>();
            stnd.Add(new Stnd());

            //int lastCnt = 0;
            string[] alpha = {"a", "b", "c", "d", "e", "f", "g", "h", "i", "j"};
            for (int i = 2; i <= N; i++)
            {
                foreach (Stnd cur in stnd)
                {
                    if (Normal[cur.Kind].Count > 0)
                    {
                        foreach (Stnd ad in Normal[cur.Kind])
                        {
                            stnd.Add(new Stnd(cur.Word + ad.Word, ad.Kind));
                        }
                    }
                    else
                    {
                        for (int j = 0; j < cur.Kind; j++)
                        {
                            stnd.Add(new Stnd(cur.Word + alpha[j], cur.Kind));
                            Normal[cur.Kind].Add(new Stnd(alpha[j], cur.Kind));
                        }
                        stnd.Add(new Stnd(cur.Word + alpha[cur.Kind], cur.Kind + 1));
                        Normal[cur.Kind].Add(new Stnd(alpha[cur.Kind], cur.Kind + 1));
                    }
                }
            }
        }

        public class Stnd
        {
            public string Word {get;}
            public int Kind {get;}

            public Stnd()
            {
                Word = "a";
                Kind = 1;
            }

            public Stnd(string word, int kind)
            {
                Word = word;
                Kind = kind;
            }
        }
    }
}

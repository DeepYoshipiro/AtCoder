using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC155
{
    class ABC155Corg
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            List<string> S = new List<string>();
            for (int i = 0; i < N; i++)
            {
                S.Add(ReadLine());
            }

            S.Sort(StringComparer.OrdinalIgnoreCase);
            Dictionary<string, int> dic = new Dictionary<string, int>();
            int maxCnt = 1;
            string curString = S[0];
            int curCnt = 0;
            for (int i = 0; i < N; i++)
            {
                if (curString == S[i])
                {
                    curCnt++;
                    if (curCnt > maxCnt) maxCnt = curCnt;
                }
                else
                {
                    dic.Add(curString, curCnt);
                    curString = S[i];
                    curCnt = 1;
                }
            }
            dic.Add(curString, curCnt);

            for (int i = 0; i < dic.Count; i++)
            {
                if (dic.ElementAt(i).Value == maxCnt)
                {
                    WriteLine(dic.ElementAt(i).Key);
                }
            }
            ReadKey();
        }
    }
}

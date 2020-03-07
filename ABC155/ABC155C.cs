using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC155
{
    class ABC155C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());
            List<string> S = new List<string>();
            for (int i = 0; i < N; i++)
            {
                S.Add(ReadLine());
            }

            S.Sort();
            List<string> result = new List<string>();
            int maxCnt = 1;
            string curString = "";
            int curCnt = 0;
            for (int i = 0; i < N; i++)
            {
                // 回数比較
                bool same = false;
                if (curString == S[i])
                {
                    same = true;
                    curCnt++;
                    if (curCnt > maxCnt)
                    {
                        // 回数が単独トップならば、
                        // 回数を更新して、リストも更新する
                        maxCnt = curCnt;
                        if (result.Count > 1)
                        {
                            result.Clear();
                        }
                        result.Add(curString);
                    }
                }
                    else if (curCnt == maxCnt)
                    {
                        result.Add(curString);
                    }
                    if (maxCnt == 1 && curString != "")
                    {
                        result.Add(curString);
                    }
                    curString = S[i];
                    curCnt = 1;

                // 要素入れ込み
            }

            for (int i = 0; i < result.Count; i++)
            {
                WriteLine(result[i]);
            }
            ReadKey();
        }
    }
}

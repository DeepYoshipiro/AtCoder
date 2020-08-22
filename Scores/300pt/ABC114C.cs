// Solution : DFS
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC114C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());

            int result = dfs("", N, false, false, false);

            WriteLine(result.ToString());
            ReadKey();
        }

        static int dfs(string curNumLiteral, int limit
                        , bool exist3, bool exist5, bool exist7)
        {
            var curNumChar = curNumLiteral.ToCharArray();
            int result = 0;
            if (curNumChar.Count() >= 10) return 0;
            int curNum = 0;
            int pow = 1;
            for (int i = curNumChar.Count() - 1; i >= 0; i--)
            {
                curNum += (curNumChar[i] - '0') * pow;
                pow *= 10;
            }
            if (curNum > limit) return 0;
            if (exist3 && exist5 && exist7) result++;

            result += dfs(curNumLiteral + "3", limit, true, exist5, exist7);
            result += dfs(curNumLiteral + "5", limit, exist3, true, exist7);
            result += dfs(curNumLiteral + "7", limit, exist3, exist5, true);
            
            return result;
        }
    }
}

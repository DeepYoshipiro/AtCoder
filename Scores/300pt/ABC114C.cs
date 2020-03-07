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
            char[] includeDigit = { '7', '5', '3' };
            int N = int.Parse(ReadLine());

            List<string> satisfyNum = new List<String> { "357", "375", "537", "573", "735", "753" };
            for (int i = 3; i <= Log(N, 10); i++)
            {
                HashSet<string> addNum = new HashSet<string>();
                foreach (string s in satisfyNum) {
                    if (s.Length == i) {
                        for (int j = 0; j < includeDigit.Length; j++) { 
                            string checkNum1 = s + includeDigit[j];
                            if (checkNum1.Contains(includeDigit[0])
                                && checkNum1.Contains(includeDigit[1])
                                && checkNum1.Contains(includeDigit[2]))
                                addNum.Add(checkNum1);

                            string checkNum2 = includeDigit[j] + s;
                            if (checkNum2.Contains(includeDigit[0])
                                && checkNum2.Contains(includeDigit[1])
                                && checkNum2.Contains(includeDigit[2]))
                                addNum.Add(checkNum2);
                        }
                    }
                }
                
                foreach (string u in addNum)
                {
                    satisfyNum.Add(u);
                }
            }

            int result = 0;
            foreach (string t in satisfyNum) {
                if (int.Parse(t) <= N) result++;
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}

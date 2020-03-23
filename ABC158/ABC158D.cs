using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC158
{
    class ABC158D
    {
        static void Main(string[] args)
        {
            const int maxQuery = 200000;
            char[] U = ReadLine().ToCharArray();
            char[] S = (new String(' ', maxQuery) 
                + new String(U) + new String(' ', maxQuery)).ToCharArray();
            int Q = int.Parse(ReadLine());
            int revMode = 0;
            int top = maxQuery - 1;
            int bottom = maxQuery + U.Length;

            for (int i = 0; i < Q; i++)
            {
                string[] query = ReadLine().Split();
                int T = int.Parse(query[0]);
                if (T == 1)
                {
                    revMode++;
                    revMode %= 2;
                }
                else
                {
                    int F = int.Parse(query[1]);
                    char append = char.Parse(query[2]);
                    switch ((revMode + F) % 2)
                    {
                        case 0:
                            S[bottom] = append;
                            bottom++;
                            break;
                        case 1:
                            S[top] = append;
                            top--;
                            break;
                    }
                }
            }
            if (revMode == 1)
            {
                Array.Reverse(S);
            }

            string result = new String(S).Trim(' ');
            WriteLine(result);
            ReadKey();
        }
    }
}

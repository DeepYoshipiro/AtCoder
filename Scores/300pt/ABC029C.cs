using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC029C
    {
        static void Main(string[] args)
        {
            int N = int.Parse(ReadLine());

            List<string>[] password = new List<string>[N + 1];
            password[1] = new List<string>();
            password[1].Add("a"); 
            password[1].Add("b"); 
            password[1].Add("c");

            for (int i = 2; i <= N; i++)
            {
                password[i] = new List<string>();
                string[] abc = new string[3]{"a" ,"b" ,"c"};
                for (int j = 0; j < abc.Length; j++)
                {
                    foreach(string pass in password[i - 1])
                    {
                        password[i].Add(abc[j] + pass);
                    }
                }
            } 

            foreach (string pass in password[N])
            {
                WriteLine(pass);
            }
            ReadKey();
        }
    }
}

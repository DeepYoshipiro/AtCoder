// using System;
// using System.Linq;
// using System.Collections.Generic;
// using System.Text;
// using static System.Console;
// using static System.Math;
 
// namespace ABC141
// {
//     class ABC141E
//     {
//         static void Main(string[] args)
//         {
//             var N = int.Parse(ReadLine());
//             string S = ReadLine();
//             var Letter = new List<int>['z' - 'a' + 1]
//                 .Select(v => new List<int>()).ToArray();
 
 
//             for (int i = 0; i < N; i++) 
//             {
//                 Letter[char.Parse(S.Substring(i, 1)) - 'a'].Add(i);
//             }
 
//             int len = 0;
//             for (int l = 0; l < 26; l++)
//             {
//                 if (Letter[l].Count() >= 2)
//                 {
//                     len = 1;
//                     break;
//                 } 
//             }
 
//             for (int l = 0; l < 26; l++)
//             {
//                 if (Letter[l].Count() <= 1) continue;
//                 for (int i = 0; i < Letter[l].Count() - 1; i++)
//                 {
//                     for (int j = i + 1; j < Letter[l].Count(); j++)
//                     {
//                         var l1 = Letter[l][i];
//                         var l2 = Letter[l][j];
 
//                         while (l2 + len < N && l1 + len < l2)
//                         {
//                             if (S.Substring(l1, len + 1) != S.Substring(l2, len + 1)) break;
//                             len++;
//                         }
//                     }
//                 }
//             }
 
//             WriteLine(len.ToString());
//             ReadKey();
//         }
//     }
// }
using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC141
{
    class ABC141E
    {
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());
            string S = ReadLine();
            var Letter = new List<int>['z' - 'a' + 1]
                .Select(v => new List<int>()).ToArray();


            for (int i = 0; i < N; i++) 
            {
                Letter[char.Parse(S.Substring(i, 1)) - 'a'].Add(i);
            }

            int len = 0;
            for (int l = 0; l < 26; l++)
            {
                if (Letter[l].Count() >= 2)
                {
                    len = 1;
                    break;
                } 
            }

            for (int l = 0; l < 26; l++)
            {
                if (Letter[l].Count() <= 1) continue;
                for (int i = 0; i < Letter[l].Count() - 1; i++)
                {
                    for (int j = i + 1; j < Letter[l].Count(); j++)
                    {
                        var l1 = Letter[l][i];
                        var l2 = Letter[l][j];

                        while (l2 + len < N && l1 + len < l2)
                        {
                            if (S.Substring(l1, len + 1) != S.Substring(l2, len + 1)) break;
                            len++;
                        }
                    }
                }
            }

            WriteLine(len.ToString());
            ReadKey();
        }
    }
}

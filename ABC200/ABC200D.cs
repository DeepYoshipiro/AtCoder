using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace ABC200
{
    class ABC200D
    {
        static void Main(string[] args)
        {
            var N = int.Parse(ReadLine());
            var A = new int[]{0}
                .Concat(ReadLine().Split()
                    .Select(n => int.Parse(n)))
                .ToArray();

            // var rest = new List<HashSet<int>>[200]
            //     .Select(v => new List<HashSet<int>>()).ToArray();
            var rest = new List<HashSet<int>>[200]
                .Select(v => new List<HashSet<int>>()).ToArray();
            var usedRest = new HashSet<int>();
            var count = new int[200];

            rest[A[1] % 200].Add(new HashSet<int>{1});
            usedRest.Add(A[1] % 200);
            
            int result = -1;
            for (int i = 1; i <= N; i++)
            {
                var newRest = new List<HashSet<int>>[200]
                    .Select(v => new List<HashSet<int>>()).ToArray();
                var newUsedRest = new HashSet<int>();
                foreach (int num in usedRest)
                {
                    foreach (HashSet<int> set in rest[num])
                    {
                        newRest[(num + A[i]) % 200].Add(set.Append(i).ToHashSet());
                        newUsedRest.Add((num + A[i]) % 200);
                    }
                    newUsedRest.Add(A[i] % 200);
                }

                foreach (int num in newUsedRest)
                {
                    rest[num].Union(newRest[num]);
                    if (rest[num].Count() >= 2)
                    {
                        result = num;
                        break;
                    }
                }
                if (result > 0) break;
                usedRest.UnionWith(newUsedRest);
            }

            WriteLine(result.ToString());
            ReadKey();
        }
    }
}
// ﻿using System;
// using System.Linq;
// using System.Collections.Generic;
// using System.Text;
// using static System.Console;
// using static System.Math;

// namespace ABC200
// {
//     class ABC200D
//     {
//         static void Main(string[] args)
//         {
//             var N = int.Parse(ReadLine());
//             var A = new int[]{0}
//                 .Concat(ReadLine().Split()
//                     .Select(n => int.Parse(n)))
//                 .ToArray();

//             // var rest = new List<HashSet<int>>[200]
//             //     .Select(v => new List<HashSet<int>>()).ToArray();
//             var rest = new List<HashSet<int>>[200]
//                 .Select(v => new List<HashSet<int>>()).ToArray();
//             var usedRest = new HashSet<int>();
//             var count = new int[200];

//             rest[A[1] % 200].Add(new HashSet<int>{1});
//             usedRest.Add(A[1] % 200);
            
//             int result = -1;
//             for (int i = 1; i <= N; i++)
//             {
//                 var newRest = new List<HashSet<int>>[200]
//                     .Select(v => new List<HashSet<int>>()).ToArray();
//                 var newUsedRest = new HashSet<int>();
//                 foreach (int num in usedRest)
//                 {
//                     foreach (HashSet<int> set in rest[num])
//                     {
//                         newRest[(num + A[i]) % 200].Add(set.Append(i).ToHashSet());
//                         newUsedRest.Add((num + A[i]) % 200);
//                     }
//                     newUsedRest.Add(A[i] % 200);
//                 }

//                 foreach (int num in newUsedRest)
//                 {
//                     rest[num].Union(newRest[num]);
//                     if (rest[num].Count() >= 2)
//                     {
//                         result = num;
//                         break;
//                     }
//                 }
//                 if (result > 0) break;
//                 usedRest.UnionWith(newUsedRest);
//             }

//             WriteLine(result.ToString());
//             ReadKey();
//         }
//     }
// }

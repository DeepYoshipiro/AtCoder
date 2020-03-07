using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class CPSCO_2019_S1C
    {

        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int K = init[1];

            long[] A = ReadLine().Split(' ')
                .Select(n => long.Parse(n)).ToArray();

            Stack<int> boughtItemCnt = new Stack<int>();
            Stack<int> itemID = new Stack<int>();
            Stack<long> price = new Stack<long>();
            for (int i = 0; i < A.Length; i++)
            {
                boughtItemCnt.Push(1);
                itemID.Push(i);
                price.Push(A[i]);
            }

            long result = long.MaxValue;
            while (price.Count > 0)
            {
                int curBoughtItem = boughtItemCnt.Pop();
                int curItem = itemID.Pop();
                long curPrice = price.Pop();

                if (curBoughtItem == K)
                {
                    int pieces = getCoinCnt(curPrice);

                    if (pieces < result)
                    {
                        result = pieces;
                    }
                    continue;
                }

                for (int j = curItem + 1; j < A.Length; j++)
                {
                    boughtItemCnt.Push(curBoughtItem + 1);
                    itemID.Push(j);
                    price.Push(curPrice + A[j]);
                }
            }
                    
            WriteLine(result.ToString());
            ReadKey();
        }

        static int getCoinCnt(long price)
        {
            int ret = 0;
            for (int i = 0; i <= 9; i++)
            {
                int rest = (int)(price % 10);
                if (rest >= 5) rest -= 4;
                ret += rest;
                price /= 10;
            }

            return ret;
        }
    }
}

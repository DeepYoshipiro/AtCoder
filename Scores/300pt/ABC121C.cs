using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt
{
    class ABC121C
    {
        static void Main(string[] args)
        {
            long[] init = ReadLine().Split(' ')
                .Select(n => long.Parse(n)).ToArray();
            long store = init[0];
            long want = init[1];

            var storeInfo = new List<StoreInfo>();

            for (int i = 0; i < store; i++)
            {
                long[] info = ReadLine().Split(' ')
                    .Select(n => long.Parse(n)).ToArray();

                storeInfo.Add(new StoreInfo() { Price = info[0], Stock = info[1] });
            }

            storeInfo = storeInfo.OrderBy(x => x.Price).ToList();

            long cost = 0;
            for (int j = 0; j < store; j++)
            {
                long price = storeInfo[j].Price;
                long stock = storeInfo[j].Stock;

                cost += price * (stock < want ? stock : want);
                want -= (stock < want ? stock : want);
                if (want <= 0) break;
            }

            WriteLine(cost.ToString());
            ReadKey();
        }

        class StoreInfo
        {
            public long Price { get; set; }
            public long Stock { get; set; }
        }
    }
}

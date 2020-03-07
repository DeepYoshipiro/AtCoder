using System;
using System.Linq;
using static System.Console;

namespace _200pt
{

    class Procon2019_qualB
    {
        static void Main(string[] args)
        {
            const int PASSAGE = 3;
            const int CITY = 4;
            //input
            int[] vehiclesHaveEdge = new int[CITY + 1];
            for (int i = 0; i < PASSAGE; i++)
            {
                int[] way = ReadLine().Split(' ')
                    .Select(n => int.Parse(n)).ToArray();

                vehiclesHaveEdge[way[0]]++;
                vehiclesHaveEdge[way[1]]++;
            }

            //calculate & output
            Array.Sort(vehiclesHaveEdge);

            if (vehiclesHaveEdge[1] == 1 && vehiclesHaveEdge[2] == 1
                && vehiclesHaveEdge[3] == 2 && vehiclesHaveEdge[4] == 2)
                WriteLine("YES");
            else
                WriteLine("NO");

            ReadKey();
        }
    }
}

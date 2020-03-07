using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static System.Console;
using static System.Math;

namespace _300pt {
    class ABC123C {
        static void Main (string[] args) {
            const int CITIES = 6;
            long N = long.Parse (ReadLine ());
            long[] rideAble = new long[CITIES - 1];
            for (int i = 0; i < rideAble.Length; i++) {
                rideAble[i] = long.Parse (ReadLine ());
            }

            long[] staying = new long[CITIES];
            staying[0] = N;

            int lap = 0;
            while (staying[CITIES - 1] < N) {
                for (int departure = CITIES - 2; departure >= 0; departure--) {
                    int arrive = departure + 1;
                    long passenger
                        = (rideAble[departure] < staying[departure]
                            ? rideAble[departure] : staying[departure]);
                    staying[arrive] += passenger;
                    staying[departure] -= passenger;
                }
                lap++;
            }

            WriteLine (lap.ToString());
            ReadKey ();
        }
    }
}
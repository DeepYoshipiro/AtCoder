using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using static System.Math;
using static System.Console;

namespace _300pt
{
    class ABC113Crev1
    {
        static void Main(string[] args)
        {
            int[] init = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int N = init[0];
            int M = init[1];

            List<City> city = new List<City>();
            for (int i = 1; i <= M; i++)
            {
                int[] info = ReadLine().Split(' ')
                    .Select(n => int.Parse(n)).ToArray();
                int P = info[0];
                int Y = info[1];

                city.Add(new City(i, P, Y));
            }

            city.Sort(CompareCity);

            int curPrefecture = 0;
            int curCityInPrefecture = 1;
            for (int i = 1; i <= M; i++)
            {
                City curCity = city[i - 1];
                if (curCity.Prefecture == curPrefecture)
                {
                    curCityInPrefecture++;
                }
                else
                {
                    curPrefecture = curCity.Prefecture;
                    curCityInPrefecture = 1;
                }
                curCity.Id = curPrefecture.ToString("000000")
                             + curCityInPrefecture.ToString("000000");
            }

            city.Sort(CompareOrder);

            for (int i = 1; i <= M; i++)
            {
                City curCity = city[i - 1];
                WriteLine(curCity.Id);
            }
            ReadKey();
        }

        static int CompareCity(City x, City y)
        {
            // 第一のキー(Prefectureフィールド)で比較
            if (x.Prefecture > y.Prefecture) {
                return 1;
            }
            else if (x.Prefecture < y.Prefecture) {
                return -1;
            }
            else /* if (x.Prefecture == y.Prefecture) */ {
                // 第一のキーが同じだった場合は、第二のキー(BuildYearフィールド)で比較
                if (x.BuildYear > y.BuildYear)
                    return 1;
                else if (x.BuildYear < y.BuildYear)
                    return -1;
                else // if (x.BuildYear == y.BuildYear)
                    return 0;
            }
        }

        static int CompareOrder(City x, City y)
        {
            // 入力順でソート
            if (x.Order > y.Order) {
                return 1;
            }
            else {
                return -1;
            }
        }
    }

    class City {
        public int Order {get;}
        public int Prefecture {get;}
        public int BuildYear {get;}
        public string Id {get; set;}

        public City(int order, int prefecture, int buildYear)
        {
            Order = order;
            Prefecture = prefecture;
            BuildYear = buildYear;
            Id = "";
        }
    }
}
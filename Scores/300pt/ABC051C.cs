using System;
using System.Linq;
using System.Text;
using static System.Console;

namespace _300pt
{

    class ABC051C
    {
        static void Main(string[] args)
        {
            //input
            int[] pos = ReadLine().Split(' ')
                .Select(n => int.Parse(n)).ToArray();
            int s_x = pos[0];
            int s_y = pos[1];
            int t_x = pos[2];
            int t_y = pos[3];

            //calculate
            StringBuilder route = new StringBuilder("");
            route.Append(NavigateRoute(s_x, s_y, t_x, t_y));
            route.Append(NavigateRoute(t_x, t_y, s_x, s_y));
            route.Append("D");
            route.Append(NavigateRoute(s_x, s_y - 1, t_x + 1, t_y));
            route.Append("LU");
            route.Append(NavigateRoute(t_x, t_y + 1, s_x - 1, s_y));
            route.Append("R");

            //output;
            WriteLine(route.ToString());
            ReadKey();
        }

        private static string NavigateRoute
            (int fromX, int fromY, int toX, int toY)
        {
            StringBuilder ret = new StringBuilder("");
            //x方向
            if (toX - fromX > 0)
                ret.Append(new String('R', toX - fromX));
            else
                ret.Append(new String('L', fromX - toX));

            //y方向
            if (toY - fromY > 0)
                ret.Append(new String('U', toY - fromY));
            else
                ret.Append(new String('D', fromY - toY));

            return ret.ToString();
        }
    }
}

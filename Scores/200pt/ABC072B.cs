using static System.Console;
using System.Text;

namespace _200pt
{
    class ABC072B
    {
        static void Main(string[] args)
        {
            //input
            char[] s = ReadLine().ToCharArray();

            //calculate
            StringBuilder oddOrder = new StringBuilder("");
            for (int i = 0; i < s.Length; i += 2) {
                oddOrder.Append(s[i]);
            }

            //output
            WriteLine(oddOrder.ToString());
            ReadKey();
        }
    }
}

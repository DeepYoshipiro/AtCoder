using static System.Console;

namespace _200pt
{
    class ABC053B
    {
        static void Main(string[] args)
        {
            //input
            string s = ReadLine();

            //calculate
            int firstA = s.IndexOf('A');
            int lastZ = s.LastIndexOf('Z');

            int result = lastZ - firstA + 1;

            //output
            WriteLine(result.ToString());
            ReadKey();
        }
    }
}

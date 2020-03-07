using static System.Console;

namespace _200pt
{
    class ABC103B
    {
        static void Main(string[] args)
        {
            //input
            string S = ReadLine();
            string T = ReadLine();

            //calculate
            bool result = false;

            string SS = S + S;
            for (int i = 0; i < S.Length; i++) {
                if (SS.Substring(i, S.Length).Equals(T)) {
                    result = true;
                    break;
                }
            }

            //output
            WriteLine(result ? "Yes" : "No");
            ReadKey();
        }
    }
}

using System;
using static System.Console;

namespace _300pt
{
    class ddcc2019_final_A
    {
        static void Main(string[] args)
        {
            //input
            int N = int.Parse(ReadLine());
            char[] S = ReadLine().ToCharArray();

            //calculate
            int maxLinkingIce = 0;
            int maxLinkingIceEndBlock = -1;
            int linkingIce = 0;
            // - なら「雪」、> なら「氷」
            //氷のブロックの最長列の長さと終了位置を探索する
            for (int i = 0; i < N; i++) {
                if (S[i].Equals('>')) { //iマス目が「氷」
                    linkingIce++;
                    if (linkingIce > maxLinkingIce) {
                        maxLinkingIce = linkingIce;
                        maxLinkingIceEndBlock = i;
                    }
                }
                else
                {   //iマス目が「雪」
                    linkingIce = 0;
                }
            }

            //氷の方が早くてレギュレーションで認められているので、
            //1マス氷に変えたい
            if (maxLinkingIceEndBlock + 1 < N)
            {
                S[maxLinkingIceEndBlock + 1] = '>';
            }
            else {
                S[maxLinkingIceEndBlock - maxLinkingIce] = '>';
            }

            decimal lapTime = 0;
            linkingIce = 0;
            for (int i = 0; i < N; i++) {
                if (S[i].Equals('>'))
                { //iマス目が「氷」
                    linkingIce++;
                    lapTime += 1 / (decimal)(linkingIce + 1);
                }
                else
                {   //iマス目が「雪」
                    linkingIce = 0;
                    lapTime++;
                }
            }

            //output
            WriteLine(lapTime.ToString());
            ReadKey();
        }
    }
}

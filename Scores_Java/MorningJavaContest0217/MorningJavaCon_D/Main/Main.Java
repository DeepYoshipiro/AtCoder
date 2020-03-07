package MorningJavaContest0217;

import java.util.*;

public class Main
{
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int K = sc.nextInt();
        int X = sc.nextInt();

        int leftBlack = X - K + 1;
        int rightBlack = X + K - 1;

        StringBuilder result = new StringBuilder();
        for (int i = leftBlack; i <= rightBlack; i++)
        {
            result.append(i);
            result.append(" ");
        }

        sc.close();

        System.out.println(result);
    }
}
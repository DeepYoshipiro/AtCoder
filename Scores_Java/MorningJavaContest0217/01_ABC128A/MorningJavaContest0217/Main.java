package MorningJavaContest0217;

import java.util.*;

public class Main
{
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int A = sc.nextInt();
        int P = sc.nextInt();

        P += A * 3;
        int result = P / 2;
        sc.close();

        System.out.println(result);
    }
}
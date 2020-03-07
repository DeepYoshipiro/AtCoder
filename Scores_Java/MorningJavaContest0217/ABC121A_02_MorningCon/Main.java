package MorningJavaContest0217;

import java.util.*;

public class Main
{
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int H = sc.nextInt();
        int W = sc.nextInt();

        int white = H * W;

        int h = sc.nextInt();
        int w = sc.nextInt();
        int result = H * W - h * W - H * w + h * w;
        sc.close();

        System.out.println(result);
    }
}
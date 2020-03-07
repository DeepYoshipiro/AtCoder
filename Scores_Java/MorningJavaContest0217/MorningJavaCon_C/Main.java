package MorningJavaContest0217;

import java.util.*;

public class Main
{
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int l1 = sc.nextInt();
        int l2 = sc.nextInt();
        int l3 = sc.nextInt();

        int result;
        if (l1 == l2) result = l3;
        else if (l2 == l3) result = l1;
        else result = l2; 

        sc.close();

        System.out.println(result);
    }
}
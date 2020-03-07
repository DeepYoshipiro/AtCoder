import java.util.*;

public class Main
{
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int A = sc.nextInt();
        int B = sc.nextInt();

        if (A < B)
        {
            int tmp = B;
            B = A;
            A = tmp;
        }

        int r = B;
        int a = A;
        int b = B;
        while (r > 0)
        {
            r = a % b;
            a = b;
            b = r;
        }

        int result = A / a * B;

        sc.close();

        System.out.println(result);
    }
}
import java.util.Scanner;

public class programm1 {
    public static void main(String[] args) {   
        Scanner iScanner = new Scanner(System.in);
        System.out.println("x:");
        int x = iScanner.nextInt();
        System.out.println("y:");
        int y = iScanner.nextInt();
        int[] arr = new int[1000];
        for (int i = 0; i < 1000; i++) {
            arr[i]=i*i*i;
        }
        for (int j = 0; j < 1000; j++) {
            if (j==x) {
                System.out.println(arr[x]);
            }
            if (j==y) {
                System.out.println(arr[y]);
            }
        }
    }
}
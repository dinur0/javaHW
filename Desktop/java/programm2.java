import java.util.Scanner;

public class programm2 {
    public static void main(String[] args) {   
        Scanner iScanner = new Scanner(System.in);
        System.out.println("Длина:");
        int len = iScanner.nextInt();
        int[] arr = new int[len];
        System.out.println("заполните массив:");
        for (int i = 0; i < arr.length; i++) {
            arr[i] = iScanner.nextInt();
        }
        System.out.println("на что умножить?");
        int x = iScanner.nextInt();
        for (int j = 0; j < arr.length; j++) {
            System.out.println(arr[j]*x);
            // arr[j] *= x ;
        }
    }
}
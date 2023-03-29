import java.util.Scanner;

public class programm3 {
    public static void main(String[] args) {   
        Scanner iScanner = new Scanner(System.in);
        System.out.println("выберите функцию: \n1.+\n2.- \n3.* \n4./ ");
        int choice = iScanner.nextInt();
        System.out.println("x:");
        int x = iScanner.nextInt();
        System.out.println("y:");
        int y = iScanner.nextInt();
        if (choice==1) {
            System.out.println(x+y);
        } else if (choice==2) {
                System.out.println(x-y);
            } else if (choice==3) {
                System.out.println(x*y);
                } else if (choice==4) {
                System.out.println(x/y);
                } else{
                    System.out.println("неверная команда");
                }
        
        }
    }
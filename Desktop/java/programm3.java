import java.util.Scanner;

public class programm3 {
    public static void main(String[] args) {   
        Scanner sc = new Scanner(System.in);
        System.out.println("кол-во строк");
        int n = sc.nextInt();
        String[] recepts = new String[n];
        for (int num = 0; num < n; num++) {
            recepts[num]=sc.next();
        }
        System.out.println("кол-во продуктов");
        int m = sc.nextInt();
        String[] products = new String[m];
        for (int r = 0; r < m; r++) {
            products[r]=sc.next();
        }
        for (int i = 0; i < recepts.length; i++) {
            String [] receptSplit = recepts[i].split("");
            for (int j = 0; j < receptSplit.length; j++) {
                for (int k = 0; k < products.length; k++) {
                    String [] productSplit = products[k].split("[-]");
                    if (receptSplit[j].equals(productsSplit[0])){
                        receptSplit[j]=productsSplit[1];
                    }
                    
                } 
            }
        System.out.print(String.join("", receptSplit));
        }
        }
    }

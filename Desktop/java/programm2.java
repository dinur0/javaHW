import java.util.Scanner;

public class programm2 {
    public static void main(String[] args) {   
        Scanner iScanner = new Scanner(System.in);
        System.out.println("строка");
        String s = iScanner.nextLine();
        String [] sArr = s.split("");
        int [] index = new int [s.length()];
        System.out.println("индексы:");
        for (int num = 0; num < index.length; num++) {
            index[num] = iScanner.nextInt();
        }
        String [] res = new String[s.length()];
        for (int i = 0; i < sArr.length; i++) {
            res[i]=sArr[index[i]-1]; //fsff//
            }
        System.out.println(String.join("", res));
        }   
}

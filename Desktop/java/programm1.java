public class programm1 {
    public static void main(String[] args) { 
        String jewels = "aB";
        String [] arrJewels = jewels.split("");
        String stones = "aaaAbbbBB";
        String [] arrStones = stones.split("");
        for (int i = 0; i < arrJewels.length; i ++){
            int count = 0;
            for (int j = 0; j < arrStones.length; j++) {
                if (arrStones[j].equals(arrJewels[i])){
                    count++;
                    }
            }
            System.out.print(arrJewels[i]+count);
        }
    }
}

package Searchs;

import java.util.Scanner ;

public class NumbersEvenNumberSum {
    public static void main(String[] args) {
        int limit = 0;
        Scanner sc = new Scanner(System.in);
        System.out.println("Entrez un nombre: ");

        limit = sc.nextInt();
        
        System.out.println(sumOfEvenNumbers(limit));
        sc.close();
    }

    private static int sumOfEvenNumbers(int limit) {
        int sum = 0;
        for(int i = 1; i<=limit; i++){
            if(i % 2 == 0){
                sum = sum + i;
            }
        }
        return sum;
    }


    
}

package Searchs;

import java.util.Scanner;

public class NumbersPGDC {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Entrez le premier nombre.");
        int n1 = sc.nextInt();
        System.out.println("Entrez le second nombre.");
        int n2 = sc.nextInt();
        
        int pgdc = 0;

        for(int i=1; i<=n1 && i<= n2; i++){
            if(n1%i==0 && n2%i==0){
                pgdc = i;
            }
        }
        System.out.printf("PGDC de %d et %d est: %d", n1, n2, pgdc);
    }
    
}

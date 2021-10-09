package Searchs;

import java.util.Scanner;

public class NumbersSumOfBinaries {
    public static void main(String[] args) {
        long binary1;
        long binary2;

        int i = 0;
        int reste = 0;
        int[] somme = new int[50];
        Scanner sc = new Scanner(System.in);

        System.out.println("Entrez le premier nombre binaire: ");
        binary1 = sc.nextLong();
        System.out.println("Entrez le second nombre binaire: ");
        binary2 = sc.nextLong();

        while(binary1 != 0 || binary2 != 0){

            somme[i++] = (int)((binary1%10 + binary2%10 + reste)%2);
            reste = (int)((binary1%10 + binary2 % 10 + reste) / 2);

            binary1 = binary1/10;
            binary2 = binary2/10;
        }

        if(reste != 0){
            somme[i++] = reste;
        }
        i--;
        System.out.println("Somme de deux nombres binaires : ");
        String answer = "";
        while(i >= 0){
            answer += somme[i--];
        }
        System.out.println("\n" + answer);
    }
}

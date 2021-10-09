package Searchs;

import java.util.Scanner;

public class NumbersEvenTest {
    public static void main(String[] args) {
        int nbr;
        System.out.println("Entrez un entier : ");
        Scanner sc = new Scanner(System.in);
        nbr = sc.nextInt();

        if(nbr % 2 == 0){
            System.out.println("Le nombre est pair");
        }else{
            System.out.println("Le nombre est impair");
        }
    }
    
}

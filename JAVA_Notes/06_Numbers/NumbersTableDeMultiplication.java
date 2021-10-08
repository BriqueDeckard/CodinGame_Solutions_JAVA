package Searchs;

import java.util.Scanner;

public class NumbersTableDeMultiplication {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Entrez la valeur :");
        int value = sc.nextInt();

        for (int i=0; i <= 10; i++) {
            System.out.println(value + "x" + i + " = " + (value * i));
        }
        sc.close();
    }
}

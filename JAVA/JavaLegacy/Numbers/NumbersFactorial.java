package Searchs;

import java.util.Scanner;

public class NumbersFactorial {
    public static void main(String[] args) {
        withoutRecursivity();
        System.out.println("Entrez un nombre a factoriser avec la recursivité");
        Scanner sc = new Scanner(System.in);
        int nb = sc.nextInt();

        System.out.println(withRecursivity(nb));
    }

    private static int withRecursivity(int nb) {
        if (nb == 0) {
            return 1;
        } else {
            return (nb * withRecursivity(nb - 1));
        }
    }

    private static void withoutRecursivity() {
        int i;
        int f = 1;
        Scanner sc = new Scanner(System.in);
        // le nombre dont on veut la factorielle
        System.out.println("Entrez un nombre: ");
        int nb = sc.nextInt();

        for (i = 1; i <= nb; i++) {
            f = f * i;
        }
        System.out.println("Factorielle de " + nb + " est: " + f);
    }
}

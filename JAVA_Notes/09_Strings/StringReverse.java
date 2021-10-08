package Searchs;

import java.util.Scanner;

public class StringReverse {
    public static void main(String[] args) {
        withStringBuilder();

        withForLoop();

    }

    private static void withForLoop() {
        Scanner sc = new Scanner(System.in);
        System.out.println("Entrez une chaine a retourner: ");
        String str = sc.nextLine();
        String newString = "";

        for (int i = str.length() - 1; i >= 0; i--) {
            newString = newString + str.charAt(i);
        }

        System.out.println(newString);
    }

    private static void withStringBuilder() {
        Scanner sc = new Scanner(System.in);
        System.out.println("Entrez une chaine a retourner: ");
        String str = sc.nextLine();

        StringBuilder sb = new StringBuilder();

        // Ajout de la chaine au string builder
        sb.append(str);

        sb = sb.reverse();

        System.out.println(sb);
    }
}

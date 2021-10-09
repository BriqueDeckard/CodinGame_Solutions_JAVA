package Searchs;

import java.util.Scanner;

public class LoopDisplayMatrix {

    public static void main(String[] args) {
        int nbLigne = 0;
        int nbColonnes = 0;

        System.out.println("Nb lignes : ");
        Scanner sc = new Scanner(System.in);
        nbLigne = sc.nextInt();
        System.out.println("Nb colonnes : ");
        nbColonnes = sc.nextInt();

        displayTheMatrix(nbLigne, nbColonnes);
        sc.close();
    }

    private static void displayTheMatrix(int nbLigne, int nbColonnes) {
        // declarer la matrice
        int[][] a = new int[nbLigne][nbColonnes];
        Scanner sc = new Scanner(System.in);
        // --- Remplissage ---
        // Parcours des lignes
        for (int i = 0; i < nbLigne; i++) {
            // Parcours des colonnes
            for (int j = 0; j < nbColonnes; j++) {
                System.out.println(String.format("Entrez la valeur à [%d][%d] : ", i, j));
                a[i][j] = sc.nextInt();
            }
        }

        // --- Affichage ---
        // Parcours des lignes
        for (int i = 0; i < a.length; i++) {
            // Parcours des colonnes
            for (int j = 0; j < a[0].length; j++) {
                System.out.println(a[i][j] + "\t");
            }
            System.out.println();
        }

        sc.close();
    }
}

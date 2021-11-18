package Searchs.Areas;

import java.util.Scanner;

public class AreaTriangle {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.println("Entrez la longueur de la base: ");
        double base = sc.nextDouble();

        System.out.println("Entrez la hauteur du triangle: ");
        double height = sc.nextDouble();

        double area = (base * height) / 2;
        System.out.println("La surface du triangle est de : " + area);
        sc.close();

    }
}

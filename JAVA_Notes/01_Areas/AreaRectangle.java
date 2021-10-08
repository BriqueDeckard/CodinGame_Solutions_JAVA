package Searchs;

import java.util.Scanner;

public class AreaRectangle {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        System.out.println("Entrez la longueur");
        double length = sc.nextDouble();

        System.out.println("Entrez la hauteur : ");
        double height = sc.nextDouble();

        double area = length * height;

        System.out.println("La surface = " + area);
        sc.close();
    }
}

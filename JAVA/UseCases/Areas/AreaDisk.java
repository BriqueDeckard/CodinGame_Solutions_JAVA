package Searchs;

import java.util.Scanner;

public class AreaDisk {

    public static void main(String[] args) {
        int ray;
        double area, pi = 3.14;
        Scanner scanner = new Scanner(System.in);
        System.out.println("Entrez le rayon du cercle : ");
        ray = scanner.nextInt();
        area = pi * ray * ray;
        System.out.println("La surface du cercle est de  : " + area);
        scanner.close();
    }
}

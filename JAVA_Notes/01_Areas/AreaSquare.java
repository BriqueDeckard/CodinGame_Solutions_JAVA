package Searchs.Areas;

import java.util.Scanner;

public class AreaSquare {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        System.out.println("Entrez la longueur du côté : ");
        double side = sc.nextDouble();
        double area = side * side;
        System.out.println("La surface est de  : " + area);
        sc.close();
    }
}

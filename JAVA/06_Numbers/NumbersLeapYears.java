package Searchs;

import java.util.Scanner;

public class NumbersLeapYears {
    public static void main(String[] args) {
        Scanner s = new Scanner(System.in);
        System.out.println("Entrez une année : ");
        int year = s.nextInt();
        boolean test = false;
        if (year % 400 == 0) {
            test = true;
        } else if (year % 100 == 0) {
            test = false;
        } else if (year % 4 == 0) {
            test = true;
        } else {
            test = false;
        }
        if (test) {
            System.out.println("L'année " + year + " est bissextile");
        } else {
            System.out.println("L'année " + year + " n'est pas bissextile");
        }
    }
}

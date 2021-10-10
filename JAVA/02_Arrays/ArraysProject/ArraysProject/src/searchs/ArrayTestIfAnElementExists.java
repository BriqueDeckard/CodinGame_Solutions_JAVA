package searchs;

import java.util.Arrays;

public class ArrayTestIfAnElementExists {
    public static void main(String[] args) {
        // --- Avec une chaine
        String[] stringTab = { "Java", "PHP", "C++" };
        System.out.println(stringElementExists(stringTab, "Java"));
        System.out.println(stringElementExists(stringTab, "PHP"));
        System.out.println(stringElementExists(stringTab, "Python"));

        // --- Avec des entiers
        int[] intTab = { 1, 2, 3, 4, 5, 10, 15, 20, 25 };
        System.out.println(intElementExists(intTab, 1));
        System.out.println(intElementExists(intTab, 10));
        System.out.println(intElementExists(intTab, 42));

    }

    private static boolean intElementExists(int[] intTab, int i) {
        for (int x : intTab) {
            if (x == i) {
                return true;
            }
        }
        return false;
    }

    private static boolean stringElementExists(String[] tab, String word) {
        return Arrays.asList(tab).stream().anyMatch(x -> x.equals(word));
    }
}

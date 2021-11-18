package searchs;

import java.util.Arrays;

public class ArraysMismatch {

    public static void main(String[] args) {
        int array1[] = { 5, 10, 15, 20, 25 };
        int array2[] = { 5, 10, 15, 20, 80, 100 };
        int index = Arrays.mismatch(array1, array2);
        System.out.println("Mismatched at: " + index);
    }
}

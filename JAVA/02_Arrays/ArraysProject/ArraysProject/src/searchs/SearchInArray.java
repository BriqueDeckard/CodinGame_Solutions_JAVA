package searchs;
import java.util.Arrays;

public class SearchInArray {

    public static void main(String[] args) {
        int array[] = { 2, 5, -2, 6, -3, 8, 0, -7, -9, 4 };
        printArray("Initial array : ", array);
        Arrays.sort(array);
        printArray("Sorted array : ", array);
        int index = Arrays.binarySearch(array, -3);
        System.out.println("Found -3 at: " + index);

    }

    private static void printArray(String message, int array[]) {
        System.out.println(message + ": [length: " + array.length + "]");

        for (int i = 0; i < array.length; i++) {
            if (i != 0) {
                System.out.print(", ");
            }
            System.out.print(array[i]);
        }
        System.out.println();
    }

}

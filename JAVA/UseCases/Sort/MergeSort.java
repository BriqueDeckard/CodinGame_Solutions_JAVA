/**
 * ALGORITHM : 
 * 
 * ALGORITHM MergeSort(array, left, right);
 *  array: array of values;
 *  left, right: Integer;
 *  center: Integer
 * 
 * START
 *      IF (left < right) THEN
 *          center <- (left + right) / 2 ;
 *          MergeSort ( array, left, center);
 *          MergeSort (array, center + 1, right);
 *          Merge(array, left, center, right);
 *      END IF
 * END
 */
public class MergeSort {

    public static void main(String[] args) {
        int[] array = { 5, 4, 6, 3, 7, 2, 8, 1, 9 };
        System.out.println("Initial array: ");
        for (int i : array) {
            System.out.println("i: " + i);
        }
        mergeSort(array);
        System.out.println("Sorted array: ");
        for (int i : array) {
            System.out.println("i: " + i);
        }
    }

    public static void mergeSort(int array[]) {
        int length = array.length;
        if (length > 0) {
            mergeSort(array, 0, length - 1);
        }
    }

    private static void mergeSort(int array[], int start, int end) {
        
        if (start != end) {
            int middle = (end + start) / 2;
            mergeSort(array, start, middle);
            mergeSort(array, middle + 1, end);
            merge(array, start, middle, end);
        }
    }

    private static void merge(int array[], int start1, int end1, int end2) {
        int start2 = end1 + 1;

        // We copy the first elements of the array
        int array1[] = new int[end1 - start1 + 1];
        for (int i = start1; i <= end1; i++) {
            array1[i - start1] = array[i];
        }

        int count1 = start1;
        int count2 = start2;

        for (int i = start1; i <= end2; i++) {
            if (count1 == start2) { // all the first array's elements were used
                break; // all the elements were classified
            } else if (count2 == (end2 + 1)) { // all the seconde array's element were used
                array[i] = array1[count1 - start1]; // We add the first array's elements
                count1++;
            } else if (array1[count1 - start1] < array[count2]) {
                array[i] = array1[count1 - start1];
                count1++;
            } else {
                array[i] = array[count2];
                count2++;
            }
        }
    }

}

public class BucketSort {

    public static void main(String[] args) {
        int[] arrayToSort = { 6, 6, 6, 8, 4, 2, 10, 10 };
        int maxValue = maxValue(arrayToSort);
        System.out.println("MaxValue: " + maxValue);
        int[] sortedArray = bucketSort(arrayToSort, maxValue);
        int sortedArrayLength = sortedArray.length;
        System.out.println("SortedArrayLength: " + sortedArrayLength);
        for (int i : sortedArray) {
            System.out.println("Sorted: " + i);
        }
    }

    /**
     * 1 - Iterates through the original array to "mark" the values that are
     * presents 2 - Iterates through the bucket. If the value is marked by "one",
     * then iterates through and fill the new sorted array with the givent value.
     * 
     * 
     * 
     * 
     * @param array:        the input array to be sorted
     * @param maximumValue: the maximum_value present in the given array
     * @return
     */
    private static int[] bucketSort(int[] array, int maximumValue) {
        // Create a new bucket
        int[] newBucket = new int[maximumValue + 1];
        // Create a new array for the sorted values
        int[] sortedArray = new int[array.length];
        // Iterate through the array to sort to create a new bucket that have the size
        // of the old array, filled with 1 if the value is present, else 0
        for (int a = 0; a < array.length; a++) {
            newBucket[array[a]]++;
        }

        int pos = 0;
        // Iterates through the new bucket.
        // If the corresponding case is greater than 0, iterates through
        for (int i = 0; i < newBucket.length; i++) {
            System.out.println("i: " + i + "\tnewBucket[i]: " + newBucket[i]);
            for (int j = 0; j < newBucket[i]; j++) {
                System.out.println("for J: " + j + " --> I: " + i);
                sortedArray[pos++] = i;
            }
        }

        return sortedArray;
    }

    private static int maxValue(int[] array) {
        int max = 0;
        for (int i = 0; i < array.length; i++) {
            if (array[i] > max) {
                max = array[i];
            }
        }
        return max;
    }
}

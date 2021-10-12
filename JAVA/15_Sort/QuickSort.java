/**
 * Like Merge Sort, QuickSort is a Divide and Conquer algorithm. It picks an
 * element as pivot and partitions the given array around the picked pivot.
 * There are many different versions of quickSort that pick pivot in different
 * ways.
 * 
 * Always pick first element as pivot. Always pick last element as pivot
 * (implemented below) Pick a random element as pivot. Pick median as pivot. The
 * key process in quickSort is partition(). Target of partitions is, given an
 * array and an element x of array as pivot, put x at its correct position in
 * sorted array and put all smaller elements (smaller than x) before x, and put
 * all greater elements (greater than x) after x. All this should be done in
 * linear time.
 * 
 * --> https://www.geeksforgeeks.org/java-program-for-quicksort/
 */
public class QuickSort {
    public static void main(String[] args) {
        int[] array = { 5, 3, 4, 6, 7, 9, 2, 8, 1 };
        System.out.println("Initial: ");
        for (int i : array) {
            System.out.println(i);
        }
        int first = 0;
        int last = array.length - 1;
        System.out.println("Sort ...");
        quickSort(array, first, last);
        System.out.println("Sorted: ");
        for (int i : array) {
            System.out.println(i);
        }
    }

    /**
     * The first method is quickSort() which takes as parameters the array to be
     * sorted, the first and the last index. First, we check the indices and
     * continue only if there are still elements to be sorted. We get the index of
     * the sorted pivot and use it to recursively call partition() method with the
     * same parameters as the quickSort() method, but with different indices:
     * 
     * @param array
     * @param begin
     * @param end
     */
    public static void quickSort(int arr[], int begin, int end) {
        if (begin < end) {
            int partitionIndex = partition(arr, begin, end);
            // System.out.println("partition index is :" + partitionIndex);
            quickSort(arr, begin, partitionIndex - 1);
            quickSort(arr, partitionIndex + 1, end);
        } else {
            // System.out.println("End < Begin");
        }
    }

    private static int partition(int arr[], int begin, int end) {
        int pivot = arr[end];
        int i = (begin - 1);
        // System.out.println("Pivot : " + pivot);
        for (int j = begin; j < end; j++) {
            if (arr[j] <= pivot) {
                i++;

                // Swap
                int swapTemp = arr[i];
                arr[i] = arr[j];
                arr[j] = swapTemp;
            }
        }

        int swapTemp = arr[i + 1];
        arr[i + 1] = arr[end];
        arr[end] = swapTemp;

        return i + 1;
    }

}

public class TypicalsArrayProcessing {

    public static void main(String[] args) {
        double[] array = ArrayWithRandomValues(10);
        MaximumArrayValue(array);
    }

    private static void MaximumArrayValue(double[] array){ 
        double max = Double.NEGATIVE_INFINITY;
        for(int i = 0; i < array.length; i++){
            if(array[i] > max) max = array[i];           
        }
        System.out.println("The max is : " + max);
        
    }  

    private static double[] ArrayWithRandomValues(int n){
        double[] a = new double[n];
        for (int i =  0 ;  i < n; i++){
            a[i] = Math.random();
        }

        for(double x:a){
            System.out.println(x);
        }

        return a;
    }
}

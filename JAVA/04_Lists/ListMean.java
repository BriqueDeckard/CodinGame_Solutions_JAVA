package Searchs;

import java.util.ArrayList;
import java.util.List;
/**
 * Calculer la moyenne d'une liste
 */
public class ListMean {

    
    /** 
     * @param args
     */
    public static void main(String[] args) {
        ArrayList<Integer> liste = new ArrayList<Integer>();
        liste.add(1);
        liste.add(2);
        liste.add(3);
        liste.add(4);
        liste.add(5);

        var mean = getListMean(liste);
        System.out.println("Mean : " + mean);

    }

    
    /** 
     * @param list
     * @return int
     */
    private static  int getListMean(List<Integer> list){

        // Find the sum
        int sum = 0;       
        
        for(int i = 0; i < list.size(); i++){
            sum += list.get(i);
        }

        // find the mean
        int mean = sum / list.size();

        return mean;
    }
    
}

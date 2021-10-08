package Searchs;

import java.util.Arrays;

public class StringEnsureThatAStringIsOnlyNumbers {
    public static void main(String[] args) {
        String[] strs = { "95", "12", "aa", "14.5" };

        Arrays.asList(strs).stream().forEach(x -> isANumber(x));

    }

    public static void isANumber(String str) {
        boolean test = true;
        try {
            Float.parseFloat(str);
        } catch (NumberFormatException e) {
            test = false;
        }
        System.out.println((test) ? str + " Est un nombre" : str + " n'est pas un nombre");
    }
}

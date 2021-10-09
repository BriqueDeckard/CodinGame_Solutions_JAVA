package Searchs;

import java.util.Arrays;

public class CharCheckIfACharacterIsALetter {
    public static void main(String[] args) {
        Character[] ch = { '?', 'A', '7' };
        Arrays.stream(ch).forEach(x -> isALetter(x));
    }

    private static void isALetter(char ch) {
        boolean isAnUpperCase = ch >= 'A' && ch <= 'Z';
        boolean isALowerCase = ch >= 'a' && ch <= 'z';
        if (isAnUpperCase || isALowerCase) {
            System.out.println(ch + " Is a letter");
        } else {
            System.out.println(ch + " Is not a letter");
        }
    }
}

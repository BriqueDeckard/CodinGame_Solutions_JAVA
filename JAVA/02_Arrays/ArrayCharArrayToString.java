package Searchs;

public class ArrayCharArrayToString {
    public static void main(String[] args) {
        withStringBuilder();
        withValueOf();

    }

    private static void withValueOf() {
        char[] array = { 'Q', 'u', 'a', 'r', 'a', 'n', 't', 'e', '-', 'd', 'e', 'u', 'x' };
        String str = String.valueOf(array);
        System.out.println(str);
    }

    private static void withStringBuilder() {
        char[] array = { 'Q', 'u', 'a', 'r', 'a', 'n', 't', 'e', '-', 'd', 'e', 'u', 'x' };
        String quaranteDeux = new String(array);
        System.out.println(quaranteDeux);
    }
}

package Searchs;

import java.util.Arrays;
import java.util.List;

public class ListListFirstAndLastOfAList {

    public static void main(String[] args) {
        List<String> languages = Arrays.asList("Java", "PHP","C++","Python");
        System.out.println("First : " + languages.get(0));
        System.out.println("Last : " + languages.get(languages.size()-1));
    }
    
}

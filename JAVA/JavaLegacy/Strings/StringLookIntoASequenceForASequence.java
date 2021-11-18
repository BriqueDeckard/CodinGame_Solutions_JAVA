package Searchs;

public class StringLookIntoASequenceForASequence {

    public static void main(String[] args) {

        String str = "Joe is the smallest thug in the west.";

        int index = str.indexOf("thug");

        if (index == -1) {
            System.out.println("Le mot n'existe pas");
        } else {
            System.out.println("Le mot est à l'index : " + index);
        }
    }

}

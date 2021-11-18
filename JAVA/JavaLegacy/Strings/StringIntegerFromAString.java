package Searchs;

/**
 * Etape 1: Remplacez tous les caractères non numériques par des espaces. Etape
 * 2: Remplacez maintenant chaque groupe d’espaces consécutifs par un seul
 * espace. Etape 3: Supprimez les espaces de début et de fin et laissez juste
 * les nombres.
 */
public class StringIntegerFromAString {

    /**
     * Point d'entrée du programme.
     * 
     * @param args
     */
    public static void main(String[] args) {
        String str = "texte123 paragrahpe12 938 loremipsum";
        System.out.println(getNumbers(str));
    }

    /**
     * Extraire les nombres d'une chaine
     * 
     * @param str
     * @return String
     */
    private static String getNumbers(String str) {
        String regex = "[^\\d]";
        // Remplacement de tous les caracter alphabetiques
        str = str.replaceAll(regex, " ");
        // supression des espaces
        str = str.trim();
        // remplacement des espaces
        str = str.replaceAll(" +", " ");

        return str;
    }
}

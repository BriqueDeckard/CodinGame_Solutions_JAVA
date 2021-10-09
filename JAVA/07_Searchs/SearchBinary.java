package Searchs;

/**
 * La recherche dichotomique est utilisée pour rechercher un élément à partir de
 * plusieurs éléments. La recherche dichotomique est plus rapide que la
 * recherche linéaire.
 * 
 * Dans la recherche dichotomique, les éléments du tableau doivent être dans
 * l’ordre croissant. Si vous avez un tableau non trié, vous pouvez trier le
 * tableau à l’aide de la méthode Arrays.sort(tableau).
 */

public class SearchBinary {
    /**
     * 
     * @param array    : Le tableau dans lequel on cherche la valeur
     * @param first    : premier element
     * @param last     : dernier element
     * @param searched : valeur recherchée
     */
    public static void binarySearch(int array[], int first, int last, int searched) {
        int counter = 0;
        int middle = (first + last) / 2;
        System.out.println("f: " + first + ", l: " + last);
        System.out.println("Middle: " + middle);

        // tant que le premier est plus petit que le dernier
        while (first <= last) {
            counter += 1;
            // Si la valeur du milieu du tableau est plus petite ou egale a la valeur du
            // dernier,
            // on répète l'opération sur une nouvelle section allant du milieu à la fin
            // Et ainsi de suite jusqu'à trouver la valeur
            // Le but est toujours d'analyser le milieu d'une section pour
            // voir s'il s'agit de la valeur recherchée.
            System.out.println("===============================");
            if (array[middle] < searched) {
                // Définie la nouvelle section a "analyser"
                first = middle + 1;
                System.out.println("First: " + first);
                // Si le milieu est egal à la valeur recherchée la valeur est trouvée, et on
                // arrête la boucle
            } else if (array[middle] == searched) {
                System.out.println("L'élément recherché se trouve à l'index: " + middle);
                break;
                // Si le milieu est
            } else {
                // l'avant dernier de la première section devient le dernier.
                last = middle - 1;
                System.out.println("Last: " + last);
            }
            // on trouve le milieu de la nouvelle section
            middle = (first + last) / 2;
            System.out.println("Middle: " + middle);
        }

        if (first > last) {
            System.out.println("L'élément n'existe pas.");
        }
    }

    public static void main(String args[]) {
        System.out.println("Hello ?");
        int tab[] = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int val = 4;
        int l = tab.length - 1;
        binarySearch(tab, 0, l, val);
    }

}
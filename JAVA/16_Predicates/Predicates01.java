import java.util.function.Predicate;

public class Predicates01 {

    public static void main(String[] args) {
        // Simple predicate
        simplePredicate();
        // More complex predicate
        Predicate<Integer> pred = Predicates01::checkMarks;

        System.out.println("Is 120 > 35 ? " + pred.test(120));

        

    }

    // #region Simple predicate
    /**
     * This program demonstrates the creation of a simple Predicate and then calling
     * that Predicate method later point of time for evaluation condition with a
     * test method as shown.
     */
    private static void simplePredicate() {
        // Instantiates the predicate
        Predicate<Integer> prdc = vl -> (vl > 20);
        // Run the predicate
        System.out.println(prdc.test(80));
    }
    // #endregion

    // #region More complex predicate
    private static Boolean checkMarks(int marks) {
        if (marks > 35) {
            return true;
        } else {
            return false;
        }
    }

    // #endregion

}

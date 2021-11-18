import java.util.Scanner;
import java.util.InputMismatchException;

public class Factorielle {

    public static void main(String[] args) {
        testFactorielle();
        printFactorielle();
    }

    private static void testFactorielle(){
        int fact10 = 3628800;
        if (getFactorielle(10) == fact10) {
            System.out.println("Success");
        } else {
            System.out.println("Fail");
        }
    }

    private static void printFactorielle() {
        Scanner sc = new Scanner(System.in);
        try {
            System.out.println("Enter a number: ");
            System.out.println(getFactorielle(sc.nextInt()));

        } catch(InputMismatchException e){
            System.out.println("Error: " + "You must enter a numeric value.");
        }
        catch (Exception e) {
            System.out.println("Error: ");
            e.printStackTrace();
        }
    }

    private static int getFactorielle(int value) {
        int result = 1;
        for (int i = 1; i <= value; i++) {
            result = result * i;
        }
        return result;

    }
}

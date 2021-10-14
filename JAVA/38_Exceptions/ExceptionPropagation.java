import java.io.IOException;

public class ExceptionPropagation {

    public static void main(String[] args) throws Exception {
        try {
            method2();
        } catch (Exception e) {
            e.printStackTrace();
        }
    }

    private static void method1() throws IOException {
        System.out.println("This method will throw an exception.");
        throw new IOException("This is an IO exception");
    }

    private static void frontMethod() throws Exception{
        System.out.println("This method will throw an exception.");
        throw new Exception("Something went wrong");
    }

    private static void method2() throws Exception {
        System.out.println("This method will catch an exception");
        try {
            frontMethod();
        } catch (Exception e) {
            throw new Exception("Front problem: ", e);
        }
    }
}

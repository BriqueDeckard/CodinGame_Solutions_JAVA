package searchs;
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;

public class ArrayToCsv {
    public static void main(String[] args) {
        String array[] = { "Hello", "World", "Of", "42" };
        writeToAFile(array);
    }

    private static void writeToAFile(String[] array) {

        try {
            String csv = String.join(",", array);
            FileWriter myWriter = new FileWriter("myFile.txt");
            myWriter.write(csv);
            myWriter.close();
            System.out.println("Successfuly wrote to the file.");
        } catch (IOException e) {
            System.out.println("An error occured");
            e.printStackTrace();
        }
    }

}

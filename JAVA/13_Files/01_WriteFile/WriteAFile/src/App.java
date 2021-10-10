
// Import the file class
import java.io.File;
import java.io.FileWriter;
import java.io.IOException;

public class App {
    public static void main(String[] args) throws Exception {
        createAFile();
        writeToAFile();
    }

    private static void writeToAFile() {
        try {
            FileWriter myWriter = new FileWriter("myFile.txt");
            myWriter.write("Alphabet");
            myWriter.close();
            System.out.println("Successfuly wrote to the file.");
        } catch (IOException e) {
            System.out.println("An error occured");
            e.printStackTrace();
        }
    }

    private static void createAFile() {
        try {
            File myObj = new File("MyFile.txt");
            if (myObj.createNewFile()) {
                System.out.println("File created: " + myObj.getName());
            } else {
                System.out.println("File already exists");
            }
        } catch (IOException e) {
            System.out.println("An error occured");
            e.printStackTrace();
        }
    }
}

import java.util.*;

/**
 * Auto-generated code below aims at helping you parse the standard input
 * according to the problem statement.
 **/
class Solution {

    public static final int INPUT_CHARACTERS = 27;

    public static void main(String args[]) {

        Scanner in = new Scanner(System.in);
        // Get the length
        int length = in.nextInt();

        // Get the height
        in.nextLine();
        int height = in.nextInt();

        // Get the text line
        in.nextLine();
        String textLine = in.nextLine();

        // Get the ascii code of the first and the last letters
        int aAsciiCode = 'A';
        int zAsciiCode = 'Z';

        int alphabetLength = 26;

        String ROWS = "";

        for (int i = 0; i < height; i++) {
            ROWS += in.nextLine();
        }

        textLine = textLine.toUpperCase();

        StringBuilder res = new StringBuilder();

        // "for" based on the height
        for (int row = 0; row < height; row++) {

            // "for" base on the text length
            for (char ch : textLine.toCharArray()) {

                // Is the char before A ?
                boolean isBeforeA = ch < aAsciiCode;
                // Is the char after Z ?
                boolean isAfterZ = ch > zAsciiCode;
                // Calculate the difference between ch and A
                int differenceBetweenChAndA = ch - aAsciiCode;
                // if pos is befora A or after Z, position is equal to alphabet length
                // Else pos is equal to the difference between char and A
                int position = isBeforeA || isAfterZ ? alphabetLength : differenceBetweenChAndA;
                // Real alphabet size
                int realAlphabetSize = length * INPUT_CHARACTERS;
                // For each row, recalculate the new position in the row
                int currentRow = realAlphabetSize * row;
                // And calculate the current position
                int currentPosition = position * length;
                // Calculate the start point
                int start = currentRow + currentPosition;
                // Extract the coresponding string
                res.append(ROWS.substring(start, start + length));
            }
            // Add a carriage return to make a new row
            res.append("\n");
        }

        System.out.println(res);

        in.close();
    }
}
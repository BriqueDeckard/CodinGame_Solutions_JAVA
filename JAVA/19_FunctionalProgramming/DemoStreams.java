
// Importing required classes
import java.io.*;
import java.util.*;
import java.util.stream.*;
import java.util.List;

public class DemoStreams {

    public static void main(String[] args) {
        List<Thing> things = Arrays.asList(new Thing("Brique", 45), new Thing("Broque", 54), new Thing("Braque", 32));

        // "collect" and "forEach" are "terminals" methods, that must be at the end of
        // the stream operation
        // Demonstration of map method
        List<String> names = things.stream().map(x -> x.getName()).collect(Collectors.toList());
        for (String n : names) {
            System.out.println("maped: " + n);
        }

        // Demonstration of filter method
        things.stream().filter(x -> x.getValue() > 35).forEach(x -> System.out.println("filtered: " + x.getName()));

        // Demonstration of sorted method
        names.stream().sorted().forEach(x -> System.out.println("Sorted: " + x));

        // collect method returns a set
        Set<Integer> squareSet = things.stream().map(x -> x.getValue()).collect(Collectors.toSet());
        System.out.println(squareSet);

        // Demonstration of reduce method
        // Identity – an element that is the initial value of the reduction operation
        // and the default result if the stream is empty
        // Accumulator – a function that takes two parameters: a partial result of the
        // reduction operation (subtotal) and the next element of the stream (element)
        int result = things.stream().map(x -> x.getValue()).reduce(0, // Identity
                (subtotal, element) -> subtotal + element); // Accumulator
        System.out.println("Result is : " + result);

        // Reduce with an array of char
        List<String> wordAsArray = Arrays.asList("\"", "h", "e", "l", "l", "o", " ", "w", "o", "r", "l", "d", "\"");
        String word = wordAsArray.stream().reduce("", // Identity
                (partialWord, letter) -> partialWord + letter);

        System.out.println("Word: " + word);

        // Streams with complex things
        List<ComplexThing> complexThingsList = Arrays.asList(new ComplexThing(new Thing("Brique", 45), "Deckard"),
                new ComplexThing(new Thing("Broque", 54), "Deckird"),
                new ComplexThing(new Thing("Braque", 45), "Dockerd"));

        // Prints the names of the nested entities
        complexThingsList.stream().map(x -> x.something.getName()).forEach(System.out::println);

        // Gets the nested entities
        List<Thing> lessComplexThingList = complexThingsList.stream().map(w -> w.something)
                .collect(Collectors.toList());
        for (Thing t : lessComplexThingList) {
            System.out.println("t: " + t.getName());
        }

        // Get a new list of things with the name of the mother entity concatenated with
        // the name of the child entity and its value
        List<Thing> renamedThingList = complexThingsList.stream()
                .map(x -> new Thing(x.getName() + "_" + x.something.getName(), x.something.getValue()))
                .collect(Collectors.toList());
        renamedThingList.stream().forEach(System.out::println);

    }
}

import java.util.ArrayList;
import java.util.List;
import java.util.function.BiFunction;
import java.util.function.Consumer;
import java.util.function.Function;

class Lambda_01 {

    public static void main(String[] args) {

        // ---- To go through a list
        List<Integer> firstList = new ArrayList<Integer>() {
            {
                add(1);
                add(2);
                add(3);
                add(4);
            }
        };

        firstList.forEach(x -> System.out.println(x));
        firstList.forEach(System.out::println);

        // ---- To define a Thread ----
        Thread myLambdaThread = new Thread(() -> {
            System.out.println("My process");
        });
        myLambdaThread.start();
        // IS EQUIVALENT TO
        Thread monThread = new Thread(new Runnable() {
            @Override
            public void run() {
                System.out.println("My process");
            }
        });
        monThread.start();

        // ---- Without parameters ----
        // We use "() -> "
        Runnable myProcess = () -> System.out.println("process");
        myProcess.run();

        // ---- With ONE parameter ----
        Consumer<String> display_1 = (param) -> System.out.println(param);
        display_1.accept("Hello world");

        // or
        Consumer<String> display_2 = param -> System.out.println(param);
        display_2.accept("Hello world");

        // ---- With multiple parameters ----
        // Adder
        BiFunction<Integer, Integer, Long> add = (val1, val2) -> (long) val1 + val2;
        // Stringifier
        Function<Long, String> stringify = (val) -> "" + val;
        // Displayer
        Consumer<String> display = (param) -> System.out.println(param);

        display.accept(stringify.apply(add.apply(10, 12)));

    }
}
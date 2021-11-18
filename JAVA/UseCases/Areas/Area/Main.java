public class Main {

    public static void main(String[] args) {
        // SQUARE
        Shape square = new Square(2);
        System.out.println(square.calculateArea());

        // RECTANGLE
        Shape rectangle = new Rectangle(2,4);
        System.out.println(rectangle.calculateArea());

        // TRIANGLE
        Shape triangle = new Triangle(1d, 2d, 5d, 3d);
        System.out.println(triangle.calculateArea());

        // DISK
        Shape disk = new Disk(4);
        System.out.println(disk.calculateArea());
        
    }
}

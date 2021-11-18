public abstract class OneSideShape implements Shape {

    public OneSideShape(double side) {
        this.side = side;
    }

    protected double side;

    @Override
    public double calculateArea() {
        return side * side;
    }
}

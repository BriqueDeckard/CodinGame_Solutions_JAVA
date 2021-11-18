import java.util.function.Function;

public abstract class ThreeSideShape implements Shape {

    private ThreeSideShape(){
        
    }
    private double[] sides;

    private double height;

    private double base;

    public ThreeSideShape(double a, double b, double c, double h) {
        this.sides = new double[3];
        this.sides[0] = a;
        this.sides[1] = b;
        this.sides[2] = c;
        this.height = h;
        calculateBase();
    }

    private void calculateBase() {
        double max = 0;
        for (double d : sides) {
            if (d > max) {
                max = d;
            }
        }
        this.base = max;
    }

    @Override
    public double calculateArea() {
        return (base * height) / 2;
    }

}

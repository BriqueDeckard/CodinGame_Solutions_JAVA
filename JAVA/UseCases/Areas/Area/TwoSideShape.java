public abstract class TwoSideShape extends OneSideShape {

    private double sideB;

    public TwoSideShape(double sideA, double sideB) {
        super(sideA);
        this.sideB = sideB;        
    }

    @Override
    public double calculateArea() {
        return this.sideB * this.side;        
    }
    
}

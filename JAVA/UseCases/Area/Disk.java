public class Disk extends OneSideShape {

    public Disk(double side) {
        super(side);
    }

    @Override
    public double calculateArea() {
        return Math.pow(this.side, 2) * Math.PI;
    }

}

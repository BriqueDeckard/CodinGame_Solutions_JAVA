package bd.notes.microservicearchitecture.customerservice.model;

public class Order {
    private int id;
    private double value;

    public Order() {
    }

    public Order(int id, double value) {
        this.id = id;
        this.value = value;
    }

    public int getId() {
        return id;
    }

    public void setId(int id) {
        this.id = id;
    }

    public double getValue() {
        return value;
    }

    public void setValue(double value) {
        this.value = value;
    }
}

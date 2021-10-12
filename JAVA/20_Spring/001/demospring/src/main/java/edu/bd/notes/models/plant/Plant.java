package main.java.edu.bd.notes.models.plant;

public interface Plant {

    public void feedWater(int quantity);

    public void feedFertilizer(int quantity);

    public String getDetails();

    public String getPlantName();

    public void setPlantName(String name);

}

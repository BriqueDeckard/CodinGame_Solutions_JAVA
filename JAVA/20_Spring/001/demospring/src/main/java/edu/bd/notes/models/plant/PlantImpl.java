package main.java.edu.bd.notes.models.plant;

import org.springframework.stereotype.Component;

@Component
public class PlantImpl implements Plant {

    private int waterQuantity = 0;

    private int fertilizerQuantity = 0;

    private String name = "";

    @Override
    public void feedFertilizer(int quantity) {
        System.out.println("FERTILIZE " + this.name + " WITH: " + quantity);
        fertilizerQuantity += quantity;

    }

    @Override
    public void feedWater(int quantity) {
        System.out.println("WATER " + this.name + " WITH: " + quantity);
        waterQuantity += quantity;

    }

    @Override
    public String getDetails() {
        return "PLANT DETAILS:\n\t-WATER: " + waterQuantity + ";\n\t-FERTILIZER: " + fertilizerQuantity + ";\n";
    }

    @Override
    public String getPlantName() {
        return this.name;
    }

    @Override
    public void setPlantName(String name) {
        this.name = name;
    }

}

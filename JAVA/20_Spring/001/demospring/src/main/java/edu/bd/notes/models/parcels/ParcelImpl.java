package main.java.edu.bd.notes.models.parcels;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;

import main.java.edu.bd.notes.models.plant.Plant;

public class ParcelImpl implements Parcel {

    private String name;

    private List<Plant> plants = new ArrayList<String>();

    @Override
    public String getName() {
        return this.name;
    }

    @Override
    public void listsPlants() {
        for (Plant p : plants) {
            System.out.println(p.toString());
        }

    }

    @Override
    public void mix() {
        Collections.shuffle(plants);

    }

    @Override
    public void putFertilizer(int quantity) {
        for (Plant p : plants) {
            p.feedFertilizer(quantiry);
        }
    }

    @Override
    public void water(int quantity) {
        for (Plant p : plants) {
            p.feedWater(quantity);
        }

    }

}

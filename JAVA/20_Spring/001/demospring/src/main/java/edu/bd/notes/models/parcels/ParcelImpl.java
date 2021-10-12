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
        plants.stream().forEach(System.out::println);

    }

    @Override
    public void mix() {
        Collections.shuffle(plants);

    }

    @Override
    public void putFertilizer(int quantity) {
        plants.stream().forEach(x -> x.feedFertilizer(quantity));

    }

    @Override
    public void water(int quantity) {
        plants.stream().forEach(x -> x.feedWater(quantity));

    }

}

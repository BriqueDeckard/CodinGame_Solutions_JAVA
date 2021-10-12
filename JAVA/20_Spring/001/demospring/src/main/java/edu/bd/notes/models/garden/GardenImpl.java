package main.java.edu.bd.notes.models.garden;

import java.util.ArrayList;
import java.util.List;
import java.util.stream.*;

import main.java.edu.bd.notes.models.gardener.Gardener;
import main.java.edu.bd.notes.models.parcels.Parcel;

public class GardenImpl implements Garden {

    private int waterDose;

    private int fertilizerDose;

    private List<Parcel> parcels = new ArrayList<Parcel>();

    private Gardener gardener;

    @Override
    public void gardening() {
        System.out.println("GARDENING WITH: " + gardener.getNom());
        System.out.println("Parcels: ");
        listParcels();
        System.out.println("Water all the garden: ");
        water();
        System.out.println("Fertilize all the garden: ");
        putFertilizer();
        System.out.println("Parcels: ");
        listParcels();        
    }

    @Override
    public void water() {
        System.out.println("GARDEN_WATER: " + waterDose);
        parcels.stream().forEach(x -> x.water(waterDose));
    }

    @Override
    public void putFertilizer() {
        System.out.println("GARDEN_FERTILIZER: " + fertilizerDose);
        parcels.stream().forEach(x -> x.putFertilizer(fertilizerDose));
    }

    @Override
    public void listParcels() {
        System.out.println("JARDIN : ");
        parcels.stream().forEach(x -> x.listsPlants());
    }

    @Override
    public void setGardener(Gardener gardener) {
        this.gardener = gardener;

    }

    @Override
    public void setFertilizerDose(int fertilizerDose) {
        this.fertilizerDose = fertilizerDose;

    }

    @Override
    public void setWaterDose(int waterDose) {
        this.waterDose = waterDose;

    }

    public void setParcels(Parcel[] parcels) {
        this.parcels.addAll(parcels);
    };

}

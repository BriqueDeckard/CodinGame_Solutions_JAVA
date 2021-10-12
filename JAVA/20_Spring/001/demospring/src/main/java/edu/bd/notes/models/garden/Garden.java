package main.java.edu.bd.notes.models.garden;

import jdk.internal.jshell.tool.resources.version;
import main.java.edu.bd.notes.models.gardener.Gardener;

public interface Garden {
    public void gardening();
    
    public void water();

    public void putFertilizer();

    public void listParcels();

    public void setGardener(Gardener gardener);

    public void setFertilizerDose(int fertilizerDose);

    public void setWaterDose(int waterDose);

    public void setParcels(Parcel[] parcels);
}

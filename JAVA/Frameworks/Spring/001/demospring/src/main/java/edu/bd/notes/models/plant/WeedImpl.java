package main.java.edu.bd.notes.models.plant;

import org.springframework.stereotype.Component;

@Component
public class WeedImpl extends PlantImpl {

    public WeedImpl() {
        super.setPlantName("WEED");
    }

    @Override
    public void feedWater(int quantity) {
        System.out.println("Attention ! Water weed ! ");
        super.feedWater(quantity);
    }

    @Override
    public void feedFertilizer(int quantity) {
        System.out.println("Attention ! Fertilizer weed ! ");
        super.feedFertilizer(quantity);
    }

}

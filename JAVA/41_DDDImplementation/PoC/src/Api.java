import domain.model.contracts.AggregateRoot;
import domain.model.contracts.Factory;
import domain.model.contracts.Gear;
import domain.model.contracts.GearFactory;
import domain.model.impl.GearFactoryImpl;
import domain.model.impl.GearImpl;
import domain.model.impl.MotorImpl;

public class Api
{
    public static void main(String[] args){
        Factory<Gear> gearFactory = new GearFactoryImpl();
        Gear engine = gearFactory.create();
        System.out.println(engine.useMotor());
    }
}

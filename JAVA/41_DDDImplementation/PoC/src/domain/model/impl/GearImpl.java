package domain.model.impl;

import domain.model.contracts.AggregateRootImpl;
import domain.model.contracts.Gear;
import domain.model.contracts.Motor;

public class GearImpl extends AggregateRootImpl implements Gear {

    private final Motor motor;

    public GearImpl(Motor motor) {
        this.motor = motor;
    }

    @Override
    public String useMotor() {
        String message = "Speed: "+ this.motor.getSpeed();
        message += "\n== POWER UP ==";
        this.motor.powerUp();
        message += "\nSpeed: " +this.motor.getSpeed();
        return message;
    }

    @Override
    public String setSpeed() {

        return "speed up";
    }

    @Override
    public String useSecondAggregation() {
        return null;
    }
}

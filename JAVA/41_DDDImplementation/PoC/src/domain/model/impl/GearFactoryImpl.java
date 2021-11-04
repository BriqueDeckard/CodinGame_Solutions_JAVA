package domain.model.impl;

import domain.model.contracts.Gear;
import domain.model.contracts.GearFactory;

public class GearFactoryImpl implements GearFactory {
    @Override
    public Gear create() {
        return new GearImpl(new MotorImpl(0));
    }
}

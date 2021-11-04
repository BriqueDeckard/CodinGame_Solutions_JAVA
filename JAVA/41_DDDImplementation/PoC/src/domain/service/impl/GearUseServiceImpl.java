package domain.service.impl;

import domain.model.contracts.Gear;
import domain.model.contracts.GearFactory;
import domain.model.impl.GearFactoryImpl;
import domain.service.contracts.GearUseService;

public class GearUseServiceImpl implements GearUseService
{

    private final GearFactory factory;

    public GearUseServiceImpl() {
        factory = new GearFactoryImpl();
    }

    @Override
    public Gear createAndTestGear(int speedValue) {
        Gear gear = factory.create();
        gear.
        return null;
    }
}

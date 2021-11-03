package domain.service.contracts;

import domain.model.contracts.Gear;

public interface GearUseService {
    Gear createAndTestGear(int speedValue);
}

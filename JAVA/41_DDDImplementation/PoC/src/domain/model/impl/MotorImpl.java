package domain.model.impl;

import domain.model.contracts.Motor;

public class MotorImpl implements Motor {

    private int motorSpeed;

    @Override
    public void powerUp() {
        motorSpeed++;

    }

    public MotorImpl(int motorSpeed) {
        this.motorSpeed = motorSpeed;
    }

    @Override
    public void powerDown() {
        motorSpeed--;
    }

    @Override
    public int getSpeed() {
        return motorSpeed;
    }
}

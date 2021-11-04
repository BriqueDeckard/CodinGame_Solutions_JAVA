package domain.model.contracts;

import domain.model.contracts.AggregateRoot;
import domain.model.contracts.Entity;

public abstract class AggregateRootImpl implements AggregateRoot, Entity<Integer> {

    private int id;

    @Override
    public Integer getId() {
        return this.id;
    }
}

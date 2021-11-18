public class ComplexThing {
    Thing something;
    String name;

    public ComplexThing(Thing thing, String name) {
        this.something = thing;
        this.name = name;
    }

    public Thing getSomething() {
        return this.something;
    }

    public String getName() {
        return this.name;
    }
}

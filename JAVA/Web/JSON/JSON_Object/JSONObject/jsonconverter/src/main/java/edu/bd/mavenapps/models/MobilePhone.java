package edu.bd.mavenapps.models;

/**
 * Sample clas for json conversion
 */
public class MobilePhone {

    // #region properties
    private String brand;
    private String name;

    private int ram;
    private int rom;
    // #endregion

    // #region Getter
    /**
     * Gets the brand.
     * 
     * @return the brand name
     */
    public String getBrand() {
        return this.brand;
    };

    /**
     * Gets the name
     * 
     * @return the name of the device
     */
    public String getName() {
        return this.name;
    };

    /**
     * Gets the ram
     * 
     * @return the ram of the device
     */
    public int getRam() {
        return this.ram;
    };

    /**
     * Gets the rom
     * 
     * @return the rom of the device
     */
    public int getRom() {
        return this.rom;
    };
    // #endregion

    // #region Setter
    /**
     * Sets the brand.
     * 
     * @param brand the brand to set
     */
    public void setBrand(String brand) {
        this.brand = brand;
    }

    /**
     * Sets the name
     * 
     * @param name the name to set
     */
    public void setName(String name) {
        this.name = name;
    }

    /**
     * Sets the ram
     * 
     * @param ram the ram to set
     */
    public void setRam(int ram) {
        this.ram = ram;
    }

    /**
     * Sets the rom
     * 
     * @param rom the rom to set.
     */
    public void setRom(int rom) {
        this.rom = rom;
    }
    // #endregion

    // #region Override
    @Override
    public String toString() {
        return "\"MobilePhone [MobileBrand " + brand + ", MobileName = " + name + ", RAM = " + ram + ", ROM = " + rom
                + "]";
    }
    // #endregion

}

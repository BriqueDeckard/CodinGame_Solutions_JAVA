package edu.bd.mavenapps.services;

import edu.bd.mavenapps.models.MobilePhone;

public class ConvertJsonService {
    public static MobilePhone getMobile(MobilePhone mobile) {
        mobile.setBrand("Samsung");
        mobile.setName("J2 Core");
        mobile.setRam(2);
        mobile.setRom(4);

        return mobile;
    }

}

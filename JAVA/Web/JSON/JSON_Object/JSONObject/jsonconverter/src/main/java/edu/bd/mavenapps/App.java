package edu.bd.mavenapps;

import com.google.gson.Gson;

import edu.bd.mavenapps.models.MobilePhone;
import edu.bd.mavenapps.services.ConvertJsonService;

/**
 * Hello world!
 *
 */
public class App {
    public static void main(String[] args) {
        MobilePhone mobilePhone = new MobilePhone();
        mobilePhone = ConvertJsonService.getMobile(mobilePhone);
        System.out.println("The JSON representation if object MobilePhone is: ");
        System.out.println(new Gson().toJson(mobilePhone));
    }
}

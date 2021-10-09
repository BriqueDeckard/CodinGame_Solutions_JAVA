package Adapter.model;
/**
 * Ane adapter.
 * @author pierre.antoine
 * Extends "ane" to use "braire" 
 * Implements "ICheval" to have "hennir"
 */
public class AneAdapter extends Ane implements ICheval{

	
	@Override
	public void hennir() {
		// TODO Auto-generated method stub
		braire();
	}

}

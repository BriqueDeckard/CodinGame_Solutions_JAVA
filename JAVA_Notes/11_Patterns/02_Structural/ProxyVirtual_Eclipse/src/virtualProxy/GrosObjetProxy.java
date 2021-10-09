package virtualProxy;

public class GrosObjetProxy implements IGrosObjet{
    // à compléter
	private static GrosObjet _instance;

	private static GrosObjet getInstance()
	{
		if(_instance == null)
		{
			_instance = new GrosObjet();
		}
		return _instance;
	}
	
	@Override
	public void premièreMéthodeAyantVraimentBesoinDeGrosObjet() {
		getInstance().premièreMéthodeAyantVraimentBesoinDeGrosObjet();
		
	}

	@Override
	public void secondeMéthodeAyantVraimentBesoinDeGrosObjet() {
		getInstance().secondeMéthodeAyantVraimentBesoinDeGrosObjet();
		
	}
	
	
}

package virtualProxy;

public class GrosObjetProxy implements IGrosObjet {
	// � compl�ter
	private static GrosObjet _instance;

	private static GrosObjet getInstance() {
		if (_instance == null) {
			_instance = new GrosObjet();
		}
		return _instance;
	}

	@Override
	public void premiereMethodeAyantVraimentBesoinDeGrosObjet() {
		getInstance().premiereMethodeAyantVraimentBesoinDeGrosObjet();
		
	}

	@Override
	public void secondeMethodeAyantVraimentBesoinDeGrosObjet() {
		getInstance().secondeMethodeAyantVraimentBesoinDeGrosObjet();
		
	}

}

package decorator;
///Concrete component
public class Texte implements TextI{
String _text;
	
	public Texte(String theString) {
		this._text = theString;
	}
	
	public Texte(TextI component) {
		this._component = component;
	}

	@Override
	public String toHTML() {
		// TODO Auto-generated method stub
		return this._text;
	}
	
	public TextI _component; 

}

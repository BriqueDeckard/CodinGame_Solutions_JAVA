/**
* 	Person.java        2019.12.02
*	CAI-IP03 Millau 2019-2020, Pas de copyright
*/
package tp_immutabilite.immutabilite.models;

import java.sql.Date;
import java.util.ArrayList;

/**
 * "Person" class.
 * 
 * @author Pierre ANTOINE
 */
public class NonMutablePerson {

	@Override
	public String toString() {
		// TODO Auto-generated method stub
		return this.get_name() + " " + this.get_age() + " " + this.get_birthDate();
	}

	/**
	 * Initializes a new instance of the "Person" class.
	 * 
	 * @param _children
	 * @param _name
	 * @param _age
	 * @param _birthDate
	 */
	public NonMutablePerson(ArrayList<NonMutablePerson> _children, String _name, int _age, Date _birthDate) {

		super();
		this._children = _children;
		this._name = _name;
		this._age = _age;
		this._birthDate = _birthDate;
	}

	/**
	 * Initializes a new instance of the "Person" class.
	 * 
	 * @param _name
	 * @param _age
	 * @param _dateOfBirth
	 */
	public NonMutablePerson(String _name, int _age, Date _dateOfBirth) {
		this(new ArrayList<NonMutablePerson>(), _name, _age, _dateOfBirth);
	}

	/**
	 * _children
	 * 
	 */
	private ArrayList<NonMutablePerson> _children;

	/**
	 * get_children
	 * 
	 * @return the _children
	 */
	public ArrayList<NonMutablePerson> get_children() {
		if (this._children == null) {
			this._children = new ArrayList<NonMutablePerson>();
		}
		return _children;
	}

	/**
	 * set_children
	 * 
	 * @param _children the _children to set
	 */
	public void set_children(ArrayList<NonMutablePerson> _children) {
		this._children = _children;
	}

	/**
	 * The name.
	 * 
	 */
	private String _name;

	/**
	 * @return the _name
	 */
	public String get_name() {
		return _name;
	}

	/**
	 * The age.
	 * 
	 */
	private int _age;

	/**
	 * @return the _age
	 */
	public int get_age() {
		return _age;
	}

	/**
	 * The Birth date
	 * 
	 */
	private Date _birthDate;

	/**
	 * retourne une copie de birthdate pour la proteger.
	 * 
	 * @return the _birthDate
	 */
	@SuppressWarnings("deprecation")
	public Date get_birthDate() {
		// On retourne une copie de la date pour que la variable reste inchangeable
		return new Date(_birthDate.getDate());
	}

}

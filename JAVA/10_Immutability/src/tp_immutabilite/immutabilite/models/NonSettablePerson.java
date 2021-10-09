package tp_immutabilite.immutabilite.models;

import java.sql.Date;
import java.util.ArrayList;

public class NonSettablePerson {

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
	public NonSettablePerson(ArrayList<Person> _children, String _name, int _age, Date _birthDate) {

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
	public NonSettablePerson(String _name, int _age, Date _dateOfBirth) {
		this(new ArrayList<Person>(), _name, _age, _dateOfBirth);
	}

	/**
	 * _children
	 * 
	 */
	private ArrayList<Person> _children;

	/**
	 * get_children
	 * 
	 * @return the _children
	 */
	public ArrayList<Person> get_children() {
		if (this._children == null) {
			this._children = new ArrayList<Person>();
		}
		return _children;
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
	 * @return the _birthDate
	 */
	public Date get_birthDate() {
		return _birthDate;
	}

}

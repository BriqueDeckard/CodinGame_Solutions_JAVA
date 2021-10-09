/**
* 	Person.java        2019.12.02
*	CAI-IP03 Millau 2019-2020, Pas de copyright
*/
package tp_immutabilite.immutabilite.models;

import java.sql.Date;
import java.util.ArrayList;
/** "Person" class to describe a person.
 * Called in demo to demonstrate mutability. 
 * @author Pierre ANTOINE
 */
public class Person {
	
	@Override
	public String toString() {
		// TODO Auto-generated method stub
		return this.get_name() + " " + this.get_age() +" " + this.getDateOfBirth(); 
	}
	/**
	 * Initializes a new instance of the "Person" class.
	 * @param _children
	 * @param _name
	 * @param _age
	 * @param _birthDate
	 */
	public Person(
			ArrayList<Person> _children, 
			String _name, 
			int _age, 
			Date _birthDate) {
		
		super();
		this._children = _children;
		this._name = _name;
		this._age = _age;
		this._dateOfBirth = _birthDate;
	}
	
	/**
	 * Initializes a new instance of the "Person" class.
	 * @param _name
	 * @param _age
	 * @param _dateOfBirth
	 */
	public Person(String _name, int _age, Date _dateOfBirth) {
		this(new ArrayList<Person>(), _name, _age, _dateOfBirth);
	}

	/**
	 * 	_children
	 * 
	 */
	private ArrayList<Person> _children ; 

	/**
	 * get_children
	 * @return the _children
	 */
	public ArrayList<Person> get_children() {
		if(this._children == null)
		{
			this._children = new ArrayList<Person>();
		}
		return _children;
	}

	/**
	 * set_children
	 * @param _children the _children to set
	 */
	public void set_children(ArrayList<Person> _children) {
		this._children = _children;
	}

	/**
	 * The name.
	 * 
	 */
	private String _name ; 
	
	/**
	 * @return the _name
	 */
	public String get_name() {
		return _name;
	}

	/**
	 * @param _name the _name to set
	 */
	public void set_name(String _name) {
		this._name = _name;
	}

	/**
	 * The age.
	 * 
	 */
	private int _age ; 
	
	/**
	 * @return the _age
	 */
	public int get_age() {
		return _age;
	}

	/**
	 * @param _age the _age to set
	 */
	public void set_age(int _age) {
		this._age = _age;
	}

	/**
	 * 	The Birth date
	 * 
	 */
	private Date _dateOfBirth ;

	/**
	 * @return the _birthDate
	 */
	public Date getDateOfBirth() {
		return _dateOfBirth;
	}

	/**
	 * @param _birthDate the _birthDate to set
	 */
	public void setDateOfBirth(Date _birthDate) {
		this._dateOfBirth = _birthDate;
	} 
	
	
}

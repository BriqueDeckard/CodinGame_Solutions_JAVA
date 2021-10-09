/**
* 	Main.java        2019.12.02
*	CAI-IP03 Millau 2019-2020, Pas de copyright
*/
package tp_immutabilite.immutabilite.api;

import java.sql.Date;
import java.util.ArrayList;
import java.util.List;

import tp_immutabilite.immutabilite.models.NonMutablePerson;
import tp_immutabilite.immutabilite.models.NonSettablePerson;
import tp_immutabilite.immutabilite.models.Person;

/** "Main" class.
 * 
 * @author Pierre ANTOINE
 */
public class Main {
	
	static Person Bob;
	static NonMutablePerson Louis;
	static NonSettablePerson Sonia;

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		demo();
		
	}
	
	static void print(String str) {
		System.out.println(str);
	}
	
	public static void muttableDemo() {
		// MUTTABLE
		Bob = new Person("Muttable Bob", 35, Date.valueOf("1991-09-09"));		
		print(Bob.toString());		
		Bob.getDateOfBirth().setYear(2009);
		Bob.getDateOfBirth().setMonth(01);
		Bob.getDateOfBirth().setDate(28);
		print(Bob.toString());	
		}
	
	public static void immuttableDemo() {
		
		//	IMMUTABLE
		// Pas de setter --> on ne peut pas changer la valeur (juste par le constructeur)
		// Certains objets restent muttables par leur getter --> Date
		// Du coup on retourne une copie
		// Age et name sont immutables
		
		Louis = new NonMutablePerson("Unmuttable Louis", 65, Date.valueOf("1954-09-09"));
		print(Louis.toString());
		Louis.get_birthDate().setYear(2009);
		Louis.get_birthDate().setMonth(01);
		Louis.get_birthDate().setDate(28);
		print(Louis.toString());

	}
	
	
	public static void nonSettableDemo() {
		Sonia = new NonSettablePerson("NonSettable Sonia", 25, Date.valueOf("1997-01-01"));
		print(Sonia.toString());
		// age, name and date of birth are not visible
	}
	public static void demo() {
		
	
	
		
		
		
		
		
	}

}

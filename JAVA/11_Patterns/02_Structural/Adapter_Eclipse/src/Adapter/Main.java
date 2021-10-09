package Adapter;

import Adapter.model.AneAdapter;
import Adapter.model.Chetland;
import Adapter.model.ICheval;
import Adapter.model.SecondAneAdapter;

public class Main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		ICheval[] chevaux = {
				new Chetland(),
				new AneAdapter(),
				new SecondAneAdapter()
				};
		for (ICheval cheval : chevaux) {
			cheval.hennir();
		}
		}

	}


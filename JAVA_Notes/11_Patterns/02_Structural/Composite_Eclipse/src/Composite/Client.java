package Composite;

public class Client {


	
public void CompositeDemo_A()
{
	Composite A = new Composite("A");
	Composite B = new Composite("B");
	Composite C = new Composite("C");
	Composite D = new Composite("D");
	Composite E = new Composite("E");
	Composite F = new Composite("F");
	Composite G = new Composite("G");
	Composite H = new Composite("H");
	
	G.add(H);
	F.add(G);
	E.add(F);
	D.add(E);
	C.add(D);
	B.add(C);
	A.add(B);
	
	A.operation();
	
	
}
	
	
}

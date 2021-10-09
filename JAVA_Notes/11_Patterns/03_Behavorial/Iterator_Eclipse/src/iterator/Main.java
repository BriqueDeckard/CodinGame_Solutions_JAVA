package iterator;

public class Main {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		demoSimple();
	}
	
	public static void demoSimple()
	{
		  var aa = new ArrayAggregate(new String[]{
		            "Objet 1",
		            "Objet 2",
		            "Objet 3",
		            "Objet 4",
		            "Objet 5",
		            "Objet 6",
		            "Objet 7",
		        });
		  
		  System.out.println(" === Itération simple ===");
	        //ArrayAggregate.NormalIterator it1 = aa.new NormalIterator(aa);
	        NormalIterator it1 = (NormalIterator) aa.getNormalIterator();
	        while(it1.hasNext()){
	            System.out.println(it1.next());
	        }
	        System.out.println(" === Itération reverse ===");
	        ReverseIterator it2 = (ReverseIterator) aa.getReverseIterator();
	        while(it2.hasNext()) {
	        	System.out.println(it2.next());
	        }
		  
	}

}

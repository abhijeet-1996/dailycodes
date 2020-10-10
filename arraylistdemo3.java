package collection;
import java.util.*;
import java.util.concurrent.CopyOnWriteArrayList;
public class arraylistdemo3 {

	public static void main(String[] args) {
		List<String> s = new CopyOnWriteArrayList<String>();
		
		s.add("abhijeet");
		s.add("prakash");
		s.add("chougule");
		System.out.println("size of list " + s.size());
		System.out.println(s);
		Iterator itr = s.iterator();
		while(itr.hasNext())
		{
			System.out.println(itr.next());
			s.remove(0);
		}
		System.out.println(s);
	}

}

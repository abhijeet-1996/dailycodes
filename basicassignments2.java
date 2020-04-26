package mypackage1;

public class basicassignments2 {
	byte m;
	basicassignments2(int a)
	{
		this.m=(byte)a;
	}
	void disp()
	{
		System.out.println("inside the disp method"+"value of m is"+m);
	}
	public static void main(String[] args) 
	{
		basicassignments2 b[]=new basicassignments2[4];
		for(int i=0, j=20;i<b.length;i++,j+=10)
		{
			b[i]= new basicassignments2(j);
		}
		for(int i=0;i<b.length;i++)
		{
			b[i].disp();
		}
	}

}

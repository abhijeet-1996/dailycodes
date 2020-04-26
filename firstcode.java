package mypackage1;
public class firstcode
{
	
	 static  Emp ref=new Emp();
	static 
	{
		System.out.println("in Test1 static");
	}
	public firstcode()
	{
		System.out.println("in Test1 no-arg constr");
	}

	{
		System.out.println("in Test1 first non-static block");
	}


	{
		System.out.println("in Test1 second non-static block");
	}		

	public static void main(String args[])
	{
		System.out.println("in main");
		firstcode t=new firstcode();
	}
}
class Emp
{
	static
	{
		System.out.println("Emp static block");
	}
}
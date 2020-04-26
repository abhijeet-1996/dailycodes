package mypackage1;
public class Demo4
{
	int k=60;
	final int num1=30;
	final static int num2=40;
	public static void main(String args[])
	{
		final int num3=50;
		System.out.println(new Demo4().num1+"\t"+num2+"\t"+num3);
		new Demo4().k=90;
		//new Demo4().num1=20; // Error
	}
}

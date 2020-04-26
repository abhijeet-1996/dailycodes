package proj1;
class emp
{
private static int cnt=20;
public static int getcnt()
{
	return cnt;
}
}
public class second {

	public static void main(String[] args) 
	{
		System.out.println("value of private static variable ="+emp.getcnt());
	}

}

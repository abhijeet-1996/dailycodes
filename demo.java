package proj1;
class A
{
private int a;
private static int b;
static
{
	b=30;
}
void setnum(int a)
{
	this.a=a;
}
int geta()
{
	return a;
}
static int getb() 
{
	return b;
}
}
class B
{
private int a;
private static int b;
static
{
	b=9990;
}
void setnum(int a)
{
	this.a=a;
}
int geta()
{
	return a;
}
static int getb() 
{
	return b;
}
}
class C
{
private int a;
private static int b;
static
{
	b=99;
}
void setnum(int a)
{
	this.a=a;
}
int geta()
{
	return a;
}
static int getb() 
{
	return b;
}
}
public class demo {

	public static void main(String[] args) 
	{
		
		A a=new A();
		a.setnum(77);
        System.out.println("static value A="+A.getb()+"\nnon static value="+a.geta());
        B b=new B();
		b.setnum(77);
        System.out.println("static value A="+b.getb()+"\nnon static value="+b.geta());
        C c=new C();
		c.setnum(77);
        System.out.println("static value A="+C.getb()+"\nnon static value="+c.geta());
	}

}
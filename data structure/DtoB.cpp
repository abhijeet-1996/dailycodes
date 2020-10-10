#include <iostream>
#include<string.h>
#include<conio.h>
using namespace std;

int s[100];
int tos = -1;
int size;

void push(int no)
{
	s[size];
	tos++;
	s[tos] = no;
}
int pop()
{
	int temp;
	temp = s[tos];
	tos--;
	return temp;
}

int main()
{
	int a;
	cout<<"enter a no \n";
	cin>>a;
	while(a)
	{
	push(a%2);
	a = a/2;
	}
	cout<<"Binary equvivalent of given no is \t";
	for(int i=tos;i>=0;i--)
	{
		cout<<pop();
	}
	getch();
return 0;
}
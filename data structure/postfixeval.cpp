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
int atTop()
{
	return s[tos];
}
int main()
{
	int x,y;
	char arr[100];
	cout<<"enter the Expression \n";
	cin>>arr;
	for(int i=0;i<strlen(arr);i++)
	{
		if(arr[i]>=48 && arr[i]<=57)
		{
			push((int)arr[i]-48);
		}
		else if(arr[i]=='+' || arr[i]=='-' || arr[i]=='*' || arr[i]=='/' || arr[i]=='%')
		{
			y = pop();
			x = pop();
			switch(arr[i])
			{
			case '+':push(x+y);break;
			case '-':push(x-y);break;
			case '*':push(x*y);break;
			case '/':push(x/y);break;
			case '%':push(x%y);break;
			}
		}
	}
	cout<<pop();
	getch();
return 0;
}
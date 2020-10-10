#include <iostream>
#include<string.h>
#include<conio.h>
using namespace std;

int s[100];
int tos = -1;
int size;

void push(char no)
{
	s[size];
	tos++;
	s[tos] = no;
}
char pop()
{
	char temp;
	temp = s[tos];
	tos--;
	return temp;
}

int main()
{
	int j=0,k=0;
	int count=0;
	char arr[10];
	cout<<"enter the paranthesis \n";
	cin>>arr;
	size = strlen(arr);
	for(int i=0;i<strlen(arr);i++)
	{
		if(arr[i]==123)
		{
			push(arr[i]);
			j++;
		}
		k=strlen(arr)-j;
	}
	
	if(j==k)
	{
		for(int i=0;i<k;i++)
		{
			if(pop()==arr[j+i]-2)
			{
			    continue;
			}
			else
			{
				cout<<"wrong bracket";
				count++;
				break;
			}
		}
		if(count==0)
		{
			cout<<"O.K";
		}
		count=0;
	}
	else if(j>k)
	{
		cout<<j-k<<" '}' missing";
	}
	else 
	{
		cout<<k-j<<" '{' missing";
	}
	getch();
return 0;
}